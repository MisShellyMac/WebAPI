function callEditRecordTypeApi()
{
    var id = $("#Id").val();
    var description = $("#Description").val();
    var mailTo = $("#MailTo").val();
    var dateAdded = $("#DateAdded").val();
    var purpose = $("#Purpose").val();
    var expectedEndDate = $("#ExpectedEndDate").val();

    var obj = { Description: description, MailTo: mailTo, DateAdded: dateAdded, Purpose: purpose, ExpectedEndDate: expectedEndDate };

    $.ajax({
        type: "PUT",
        data: JSON.stringify(obj),
        url: "/api/recordtypes/" + id,
        contentType: "application/json",
        success: function () { document.location.href = "/"; }
    });
}

function callCreateRecordTypeApi() {
    var description = $("#Description").val();
    var mailTo = $("#MailTo").val();
    var dateAdded = $("#DateAdded").val();
    var purpose = $("#Purpose").val();
    var expectedEndDate = $("#ExpectedEndDate").val();

    var obj = { Description: description, MailTo: mailTo, DateAdded: dateAdded, Purpose: purpose, ExpectedEndDate: expectedEndDate };

    $.ajax({
        type: "POST",
        data: JSON.stringify(obj),
        url: "/api/recordtypes",
        contentType: "application/json",
        success: function () { document.location.href = "/"; }
    });
}
