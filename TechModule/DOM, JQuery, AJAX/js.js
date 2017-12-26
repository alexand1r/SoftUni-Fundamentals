function callKinvey() {
    let USERNAME = "guest", PASSWORD = "guest"
    let authBase64 = btoa(USERNAME + ":" + PASSWORD)
    $.ajax({
        method: "GET",
        url: "https://baas.kinvey.com/appdata/kid_rkZR7uur/posts",
        headers: {"Authorization": "Basic " + authBase64},
        success: function (data, status) {
            showPosts(data)
        },
        error: showError
    });
}

function showPosts(posts) {//data, status) {
//            let ul = $('<ul>')
//            for (let post of data) {
//                ul.append($('<li>').text(
//                        post.title + " -> " + post.body));
//            }
//            $('body').append(ul);
    // $('body').append(JSON.stringify(data));
    for (let p of posts) {
        $('body').append($('<div class="title">').text(p.title))
        $('body').append($('<div class="body">').text(p.body))
    }
}
function showError(data, status) {
    let errorMsg = "Error: " + JSON.stringify(data);
    $('body').append($('<div>').text(errorMsg));
}

function createPost() {
    let USERNAME = "guest", PASSWORD = "guest"
    let authBase64 = btoa(USERNAME + ":" + PASSWORD)
    $.ajax({
        method: "POST",
        url: "https://baas.kinvey.com/appdata/kid_rkZR7uur/posts",
        headers: {"Authorization": "Basic " + authBase64},
        data: {
            title: $('#newPostTitle').val(),
            body: $('#newPostBody').val()
        },
        success: function (data, status) {
            callKinvey()
        },
        error: showError
    });
}
