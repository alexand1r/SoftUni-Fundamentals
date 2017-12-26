const kinveyAppID = 'kid_Bkswp9KS';
const kinveyAppSecret = '4d97430cca83416b8516ae890b6e6106';
const kinveyServiceBaseUrl = 'https://baas.kinvey.com/';

function showView(viewId) {
    $("main > section").hide();
    $("#" + viewId).show();
}

function showHideNavigationLinks() {
    let loggedIn = sessionStorage.authToken != null;
    if (loggedIn) {
        $("#linkLogin").hide();
        $("#linkRegister").hide();
        $("#linkListBooks").show();
        $("#linkCreateBook").show();
        $("#linkLogout").show();
    }
    else {
        $("#linkLogin").show();
        $("#linkRegister").show();
        $("#linkListBooks").hide();
        $("#linkCreateBook").hide();
        $("#linkLogout").hide();
    }
}

$(function () {
    $("#linkHome").click(showHomeView);
    $("#linkLogin").click(showLoginView);
    $("#linkRegister").click(showRegisterView);
    $("#linkListBooks").click(showListBooksView);
    $("#linkCreateBook").click(showCreateBookView);
    $("#linkLogout").click(logout);

    $("#formLogin").submit(function(e) { e.preventDefault(); login(); });
    $("#formRegister").submit(function(e) { e.preventDefault(); register(); });
    $("#formCreateBook").submit(function(e) { e.preventDefault(); createBook(); });

    $(document)
        .ajaxStart(function() {
            $("#loadingBox").show();
        })
        .ajaxStop(function() {
            $("#loadingBox").hide()
        });

    showHomeView();
    showHideNavigationLinks()
});

function showHomeView() {
    showView('viewHome');
}

function showLoginView() {
    showView('viewLogin');
}

function login() {
    let authBase64 = btoa(kinveyAppID + ":" + kinveyAppSecret);
    let loginUrl = kinveyServiceBaseUrl + "user/" + kinveyAppID + "/login";
    let loginData = {
        username: $("#loginUser").val(),
        password: $("#loginPass").val()
    };
    $.ajax({
        //cache: false,
        method: "POST",
        url: loginUrl,
        data: loginData,
        headers: { "Authorization": "Basic " + authBase64 },
        success: loginSuccess,
        error: showAjaxError
    });

    function loginSuccess(data, status) {
        sessionStorage.authToken = data._kmd.authtoken;
        //showListBooksView();
        showHomeView();
        showHideNavigationLinks();
        showInfo("Login Successful");
    }
}

function showInfo(messageText) {
    $("#infoBox").text(messageText).show().delay(3000).fadeOut();
}

function showError(messageText) {
    $('#errorBox').text(messageText);
    $('#errorBox').show();
}

function showAjaxError(data, status) {
    let errorMsg = "Error: " + JSON.stringify(data);
    $('#errorBox').text(errorMsg).show();
    if (data.readyState === 0)
        errorMsg = "Cannot connect due to network error.";
    if (data.responseJSON && data.responseJSON.description)
         errorMsg = data.responseJSON.description;
    showError(errorMsg);
}

function showRegisterView() {
    showView('viewRegister');
}

function register() {
    let authBase64 = btoa(kinveyAppID + ":" + kinveyAppSecret);
    let loginUrl = kinveyServiceBaseUrl + "user/" + kinveyAppID + "/";
    let loginData = {
        username: $("#registerUser").val(),
        password: $("#registerPass").val()
    };
    $.ajax({
        //cache: false,
        method: "POST",
        url: loginUrl,
        data: loginData,
        headers: { "Authorization": "Basic " + authBase64 },
        success: registerSuccess,
        error: showAjaxError
    });

    function registerSuccess(data, status) {
        sessionStorage.authToken = data._kmd.authtoken;
        //showListBooksView();
        showHomeView();
        showHideNavigationLinks();
        showInfo("User registered successful");
    }
}

function showListBooksView() {
    $('#books').empty();
    showView('viewListBooks');

    let booksUrl = kinveyServiceBaseUrl + "appdata/" + kinveyAppID + "/books";
    let authHeaders = {
        "Authorization": "Kinvey " + sessionStorage.authToken
    }
    let newBookData = {
        title: $("#bookTitle").val(),
        author: $("#bookAuthor").val(),
        description: $("#bookDescription").val()
    };
    $.ajax({
        //cache: false,
        method: "GET",
        url: booksUrl,
        data: newBookData,
        headers: authHeaders,
        success: booksLoaded,
        error: showAjaxError
    });

    function booksLoaded(books, status) {
        showInfo("Books Loaded");
        let booksTable = $("<table>")
            .append($("<tr>")
                .append($('<th>Title</th>'))
                .append($('<th>Author</th>'))
                .append($('<th>Description</th>'))
            );
        for (let book of books) {
            booksTable.append($("<tr>")
                .append($('<td></td>').text(book.title))
                .append($('<td></td>').text(book.author))
                .append($('<td></td>').text(book.description))
            );
        }
        $("#books").append(booksTable)

    }
}

function showCreateBookView() {
    showView('viewCreateBook');
}

function createBook() {
    let booksUrl = kinveyServiceBaseUrl + "appdata/" + kinveyAppID + "/books";
    let authHeaders = {
        "Authorization": "Kinvey " + sessionStorage.authToken,
        "Content-Type": "application/json"
    };
    let newBookData = {
        title: $("#bookTitle").val(),
        author: $("#bookAuthor").val(),
        description: $("#bookDescription").val(),
        comments: [{author: "pesho", commentText: "uhahahahaha"},
            {author: "gosho", commentText: "ehahahahaha"}]
    };
    $.ajax({
        //cache: false,
        method: "POST",
        url: booksUrl,
        data: JSON.stringify(newBookData),
        headers: authHeaders,
        success: bookCreated,
        error: showAjaxError
    });

    function bookCreated(data) {
        showListBooksView();
        showInfo("Book Created");
    }
}

function logout() {
    sessionStorage.clear();
    showHomeView();
    showHideNavigationLinks();
}