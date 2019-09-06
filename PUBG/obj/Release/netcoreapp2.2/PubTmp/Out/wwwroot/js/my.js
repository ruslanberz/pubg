$(document).ready(function () {
   
   
    $("#newsletter").submit(function (e) {
        e.preventDefault();
        var Email = $("#emailsign").val();
       
        $.ajax({

            url: "/home/subscribe",
            dataType: "JSON",
            type: "POST",
            data: {
                Email: Email
            },
            success: function (response) {

                if (response.message=="Ok") {

                    toastr["success"]("Yeni xəbər paylaşıma uğurlu qoşuldunuz!");

                }
                else {
                    toastr["warning"]("E-poçtunuz artıq xəbərlərə qoşuludur");

                }

            }
        });
    });
    $("#contactFormCustom").submit(function (e) {
        e.preventDefault();
        var name = $("#namec").val();
        var email = $("#emailc").val();
        var message = $("#messagec").val();
        $.ajax({

            url: "/home/contact",
            dataType: "JSON",
            type: "POST",
            data: {
                name:name,
                email: email,
                message:message
            },
            success: function (response) {

                if (response.message == "Ok") {

                    toastr["success"]("Müraciətinizə gorə təşəkkur edirik!");
                     $("#namec").val("");
                   $("#emailc").val("");
                    $("#messagec").val("");
                    $("html, body").animate({ scrollTop: 0 }, "slow")


                }
                else {
                    toastr["warning"]("Xəta baş verdi. Zəhmət olmasa bir necə dəqiqə sonra bir daha cəhd edin");

                }

            }
        });

      
    });

});