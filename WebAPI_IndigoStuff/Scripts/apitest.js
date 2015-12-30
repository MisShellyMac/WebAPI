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

function callEditDataRecordApi() {
    var id = $("#Id").val();
    var data = $("#Data").val();
    var dateAdded = $("#DateAdded").val();
    var recordTypeId = $("#RecordTypeId").val();

    var obj = { Data: data, DateAdded: dateAdded, RecordTypeId: recordTypeId };

    $.ajax({
        type: "PUT",
        data: JSON.stringify(obj),
        url: "/api/datarecords/" + id,
        contentType: "application/json",
        success: function () { document.location.href = "/DataRecordsView"; }
    });
}

function callCreateDataRecordApi() {
    var data = $("#Data").val();
    var dateAdded = $("#DateAdded").val();
    var recordTypeId = $("#RecordTypeId").val();

    var obj = { Data: data, DateAdded: dateAdded, RecordTypeId: recordTypeId};

    $.ajax({
        type: "POST",
        data: JSON.stringify(obj),
        url: "/api/datarecords",
        contentType: "application/json",
        success: function () { document.location.href = "/DataRecordsView"; }
    });
}
