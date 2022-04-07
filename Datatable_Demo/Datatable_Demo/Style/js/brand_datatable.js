$(function () {
    $.ajax({
        type: "POST",
        url: "/Brand/LoadData",
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: OnSuccess,
        failure: function (response) {
            alert(response.d);
        },
        error: function (response) {
            alert(response.d);
        }
    });
});

function OnSuccess(response) {
    $("#demoGrid").DataTable(
        {
            lengthMenu: [[5, 10, -1], [5, 10, "All"]],
            processing: true,
            data: response,
            columns: [
                { 'data': 'Id' },
                { 'data': 'Name' }
            ]
        });
};