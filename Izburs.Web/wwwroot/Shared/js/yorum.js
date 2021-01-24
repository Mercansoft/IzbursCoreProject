$(function () {
    $.("#YorumGonder").click(function () {
        var AdSoyad = $("#contact_name").val();
        var Email = $("#contact_email2").val();
        var Mesaj = $("#contact_message2").val();
        var HaberId = $("#HaberId").val();
        $.ajax({
            type: "POST",
            url: "/Haber/YorumGonder",
            data: { AdSoyad: AdSoyad, Email: Email, Mesaj: Mesaj, HaberId: HaberId },
            dataType: "json",
            success: function (data) {
                if (data == "ok") {
                    $("#sonuc").append("<div class='alert alert-success'>Tebrikler! Yorumunuz Başarıyla Gönderildi. Onaylandıktan sonra gösterilecektir.</div>");
                } else {
                    $("#sonuc").append("<div class='alert alert-danger'>Hata! Yorumunuz Başarısız oldu.</div>");
                }
            }

        });


    });
});