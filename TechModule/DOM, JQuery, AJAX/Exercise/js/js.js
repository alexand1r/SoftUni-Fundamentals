function addItemToList(text) {
    let li = $('<li>')
        .append($("<span>").text(text))
        .append(" ")
        .append($("<a href='#' onclick='deleteItem(this)'>[Delete]</a>"));
    $("#items").append(li);
}

$(function () {
    addItemToList("First")
    addItemToList("Second")
});

function deleteItem(link) {
    $(link).parent().remove();
}

function addItem() {
    let text = $('#newItemText').val();
    addItemToList(text);
    $("#newItemText").val('');
}

$(function() {
    $('#newItemText').keypress(function(e) {
        if (e.keyCode == 13) {
            $('#newItemText + input[type="button"]').click();
        }
    })
});

//***************************************

function addCountryToTable(country, capital) {
    let row = $('<tr>')
        .append($("<td>").text(country))
        .append($("<td>").text(capital))
        .append($("<td>")
            .append($("<a href='#' onclick='moveRowUp(this)'>[Up]</a>"))
            .append(" ")
            .append($("<a href='#' onclick='moveRowDown(this)'>[Down]</a>"))
            .append(" ")
            .append($("<a href='#' onclick='deleteRow(this)'>[Delete]</a>"))
        );
    $("#countriesTable").append(row);
    return row;
}

$(function() {
    addCountryToTable("Bulgaria", "Sofia")
    addCountryToTable("Germany", "Berlin")
    addCountryToTable("Russia", "Moscow")
    addCountryToTable("France", "Paris")
    addCountryToTable("India", "Delhi")
    fixRowLinks()
});

function addCountry() {
    let country = $('#newCountryText').val();
    let capital = $('#newCapitalText').val();
    addCountryToTable(country, capital, true);
    row.hide();
    row.fadeIn();
    $('#newCountryText').val('');
    $('#newCapitaltext').val('');
    fixRowLinks()
}

function deleteRow(link) {
    let row = $(link).parent().parent();
    row.fadeOut(function() {
        row.remove();
        fixRowLinks()
    });
}

function moveRowUp(link) {
    let row = $(link).parent().parent();
    row.fadeOut(function() {
        row.insertBefore(row.prev());
        row.fadeIn();
        fixRowLinks()
    });
}

function moveRowDown(link) {
    let row = $(link).parent().parent();
    row.fadeOut(function() {
        row.insertAfter(row.next());
        row.fadeIn();
        fixRowLinks();
    });
}

function fixRowLinks() {
    //Show all links in the table
    $('#countriesTable a').show();

    //Hide [Up] link in the first table row after
    let tableRows = $('#countriesTable tr');
    $(tableRows[1]).find("a:contains('Up')").hide();

    //Hide [Down] link in the last table row
    $(tableRows[tableRows.length-1]).find("a:contains('Down')").hide();
}