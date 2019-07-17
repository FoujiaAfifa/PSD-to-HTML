$(document).ready(function () {

    $("#email_error_msg").hide();
    $("#password_error_msg").hide();

    $('#form').submit(function (e) {
   
        e.preventDefault();
        var email = $('#exampleInputEmail1').val();
        var password = $('#exampleInputPassword1').val();

        $(".error").remove();

        if (email.length < 1) {
            $("#email_error_msg").html("This field is required");
            $("#email_error_msg").show();
        } 
        
     else {
            $("#email_error_msg").hide();
        }


        if (password.length < 1) {
            
            $("#password_error_msg").html("This field is required");
            $("#password_error_msg").show();
        }

        else {
            $("#password_error_msg").hide();
        }
    });

});