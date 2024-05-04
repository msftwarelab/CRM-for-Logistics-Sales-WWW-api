var timeInterval = setInterval(sendIntercomData, 1000);
var $divStepOne = $("#divStepOne");

var $buttons = {
    setup_subscriber: $("#btnFreeTrialBegin")
};

var $inputs = {
    txtEmailAddress: $("#txtEmailAddress"),
    txtFullName: $("#txtFullName"),
    txtCompany: $("#txtCompany"),
    ddlCountry: $("#ddlCountry"),
    txtPassword: $("#txtPassword")
};

$(function () {

    $buttons.setup_subscriber.unbind('click').click(function () {
        $divStepOne.find(".error").removeClass("error");

        if ($inputs.txtEmailAddress.val() === "" || !isEmail($inputs.txtEmailAddress.val())) {
            $inputs.txtEmailAddress.addClass("error");
        }
        if ($inputs.txtFullName.val() === "") {
            $inputs.txtFullName.addClass("error");
        }
        if ($inputs.txtCompany.val() === "") {
            $inputs.txtCompany.addClass("error");
        }
        if ($inputs.txtPassword.val() === '') {
            $inputs.txtPassword.addClass('error');
        }
        if ($inputs.ddlCountry.val() === '') {
            $inputs.ddlCountry.addClass('error');
        }
        if ($divStepOne.find(".error").length === 0) {
            setupSubscriber();
        }
    });


});


function setupSubscriber() {

    var request = new Object();
    request.CompanyName = $.trim($inputs.txtCompany.val());
    request.ContactName = $.trim($inputs.txtFullName.val());
    request.Email = $.trim($inputs.txtEmailAddress.val());
    request.CountryName = $.trim($inputs.ddlCountry.val());
    request.Password = $inputs.txtPassword.val();

    $.ajax({
        type: 'POST',
        url: '/api/subscriber/SetupSubscriber',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        timeout: 70000,
        data: JSON.stringify(request),
        success: function (response) {
            if (!response.IsError) {
                if (response.UserGuid !== '') {
                    location.href =
                        'https://crm.firstfreight.com/login.aspx?lGuid=' +
                        response.UserGuid;
                } else
                    location.href =
                        'https://crm.firstfreight.com/login.aspx';
            } else {
                alert('error');
            }
        },
        beforeSend: function () {
          // $('#loadingModal').modal('show'); t
            startTrialMessageTimer();
        },
        error: function () { },
    });

}


function sendIntercomData() {
    var userdata = {
        email: $.trim($('#userEmailAddress').val()),
        contactName: $.trim($('#txtFullName').val()),
        companyName: $.trim($('#txtCompany').val()),
        city: $.trim($('#txtCity').val()),
    };

    if (
        userdata.email !== '' &&
        userdata.contactName !== '' &&
        userdata.companyName !== '' &&
        userdata.city !== ''
    ) {
        // Intercom trackEvent
        Intercom('trackEvent', 'FreeTrialSignup', userdata);
        clearInterval(timeInterval);
    }
}


function startTrialMessageTimer() {
    var messages = [];
    messages.push({
        message: 'Thank you for signing up with First Freight CRM.',
        seconds: 5,
    });
    messages.push({
        message:
            'We are setting up your account... This might take few seconds.',
        seconds: 5,
    });
    messages.push({
        message: 'Almost there... You will shortly be redirected to the CRM...',
        seconds: 25,
    });

    var i = 0;

    (function loop() {
        $('#loading-text').html(messages[i].message);
        if (++i < messages.length) {
            setTimeout(loop, messages[i].seconds * 1000);
        }
    })();
}


function isEmail(email) {
    var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(email);
}

$(window).resize(function () {
    if ($(window).height() < 700) {
        $('.footer').css('position', 'relative');
        $('.footer').addClass('relative');
    } else {
        $('.footer').css('position', 'fixed');
        $('.footer').removeClass('relative');
    }
});

$(document).ready(function () {
    if ($(window).height() < 700) {
        $('.footer').addClass('relative');
        $('.footer').css('position', 'relative');
    }

    $('#divStepTwo .form-control').on('keyup', function () {
        if ($(this).val() !== '') {
            $(this).removeClass('error');
        }
    });
    $('#divStepThree .form-control').on('keyup', function () {
        if ($(this).val() !== '') {
            $(this).removeClass('error');
        }
    });
});

$(document).ready(function () {
    $('#BtnStepTwoBack').on('click', function () {
        $('#divStepTwo .form-control').removeClass('error');
        $('#divStepTwo .form-control').required = false;
    });
});
