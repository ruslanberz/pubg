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

});