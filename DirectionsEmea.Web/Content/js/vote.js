var app = {};

app.post = function(url, data, callback) {
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
}

$(document).ready(function () {

    $("#btnSave").click(function () {
        var badgeId = $('#badgeid').val();
        app.post('/api/vote/save', { BadgeId: badgeId }, function (result) {

        });
    });
});
