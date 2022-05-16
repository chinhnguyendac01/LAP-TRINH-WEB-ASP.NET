

function doSearch(page) {
    var url = $("#searchInput").prop("action");
    var input = $("#searchInput").serializeArray();
    input.push({ "name": "page", "value": page });

    $.ajax({
        type: "GET",
        url: url,
        data: input,
        success: function (data) {
            $("#searchResult").html(data)
        }
    });
}


function clearForm() {
    $("input:text").val("");
    $("select").val("0");
}