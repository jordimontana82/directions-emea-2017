var app = {};

app.post = function (url, data, callback) {
    $.ajax({
        method: 'POST',
        url: url,
        data: JSON.stringify(data),
        contentType: 'application/json',
        dataType: 'json'
    }).done(function (result) {
        if (callback)
            callback(result);
    });
};

app.showError = function (alertSelector, errorTitle, errorMessage) {
    $(alertSelector).html('<strong>' + errorTitle + ':</strong><br/>' + errorMessage);
    $(alertSelector).show();
};

app.hideError = function (alertSelector) {
    $(alertSelector).hide();
};

$(document).ready(function () {

    $("#btnSave").click(function () {
        var badgeId = $('#badgeid').val();
        app.post('/api/vote/save', { BadgeId: badgeId }, function (result) {

            if (result.Success) {
                $('#modal-vote-success').modal('show');
            }
            else {
                app.showError('.alert', 'Error saving your vote', result.ErrorMessage);
            }

            $('#badgeid').val('');
        });
    });
});
