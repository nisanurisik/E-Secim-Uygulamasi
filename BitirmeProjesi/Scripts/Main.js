        $(document).on("click", "#secimKaydet", function () {
        var degerler = {
            secimAd: $("#secimAd").val(),
            baslangicTarihi: $("#baslangicTarihi").val(),
            bitisTarihi: $("#bitisTarihi").val()
        };
        $.ajax({
            method: 'POST',
            url: '/Secim/EkleJson',
            data: JSON.stringify(degerler),
            dataType: 'JSON',
            contentType: 'application/json;charset=utf-8',
            success: function (gelenDeg) {
                console.log(gelenDeg);
                /*debugger;*/
                if (gelenDeg == "1") {
                    Swal.fire({
                        type: 'success',

                        title: 'Seçim Eklendi',
                        text: 'İşlem başarıyla gerçekleşti'
                    });
                }
                else if (gelenDeg === "bosOlmamalı") {
                    Swal.fire({
                        type: 'error',
                        title: 'Seçim Eklenmedi',
                        text: 'Boş alanlar doldurulmalı'
                    });
                }
            },
            error: function () {
                Swal.fire({
                    type: 'error',
                    title: 'Seçim Eklenmedi',
                    text: 'İşlem gerçekleşmedi'
                });
            }

        })
            return false;
    });

$(document).on("click", "#adayKaydet", function () {
    
    var degerler = {
        kullaniciId: $("#kullaniciId").val(),
        secimId: $("#secimId").val(),
        adayParti: $("#adayParti").val()
    };
    $.ajax({
        method: 'POST',
        url: '/Aday/EkleJson',
        data: JSON.stringify(degerler),
        dataType: 'JSON',
        contentType: 'application/json;charset=utf-8',
        success: function (gelenDeg) {
            console.log(gelenDeg);
            
            if (gelenDeg == "1") {
                Swal.fire({
                    type: 'success',

                    title: 'Aday Eklendi',
                    text: 'İşlem başarıyla gerçekleşti'
                });
            }
            else if (gelenDeg === "bosOlmamalı") {
                Swal.fire({
                    type: 'error',
                    title: 'Aday Eklenmedi',
                    text: 'Boş alanlar doldurulmalı'
                });
            }
        },
        error: function () {
            Swal.fire({
                type: 'error',
                title: 'Aday Eklenmedi',
                text: 'İşlem gerçekleşmedi'
            });
        }

    })
    return false;
});
$(document).on("click", "#kullaniciKaydet", function () {
    var degerler = {
        kullaniciAd : $("#kullaniciAd").val(),
        kullaniciSoyad : $("#kullaniciSoyad").val(),
        kullaniciTc : $("#kullaniciTc").val(),
        kullaniciDogum : $("#kullaniciDogum").val(),
        /*kullaniciIlce = $("#kullaniciIlce").val(),*/
        kullaniciYetki : $("#kullaniciYetki").val(),
        kullaniciOy: $("#kullaniciOy").val(),
        kullaniciSifre: $("#kullaniciSifre").val(),
        kullaniciGirisAdi: $("#kullaniciGirisAdi").val()
    };

    $.ajax({
        type: 'Post',
        url: '/Kullanici/EkleJson',
        data: JSON.stringify(degerler),
        dataType: 'JSON',
        contentType: 'application/json;charset=utf-8',
        success: function (gelenDeg) {
            debugger;
            if (gelenDeg == "1") {
                Swal.fire({
                    type: 'success',
                    title: 'Kullanıcı Eklendi',
                    text: 'İşlem başarıyla gerçekleşti'
                });
            }
            else if (gelenDeg === "bosOlmamalı") {
                Swal.fire({
                    type: 'error',
                    title: 'Kullanıcı Eklenmedi',
                    text: 'Boş alanlar doldurulmalı'
                });
            }
        },
        error: function () {
            Swal.fire({
                type: 'error',
                title: 'Kullanıcı Eklenmedi',
                text: 'İşlem gerçekleşmedi'
            });
        }
    });

});

    $(document).on("click", "#kampanyaKaydet", function () {
        var degerler = {
            kampanyaAd : $("#kampanyaAd").val(),
            adayAdi : $("#adayAdi").val(),
            kampanyaMetni : $("#kampanyaMetni").val()
        };

        $.ajax({
            type: 'Post',
            url: '/Kampanya/EkleJson',
            data: JSON.stringify(degerler),
            dataType: 'JSON',
            contentType: 'application/json;charset=utf-8',
            success: function (gelenDeg) {
                debugger;
                if (gelenDeg == "1") {
                    Swal.fire({
                        type: 'success',
                        title: 'Kampanya Eklendi',
                        text: 'İşlem başarıyla gerçekleşti'
                    });
                }
                else if ("bosOlmamalı") {
                    Swal.fire({
                        type: 'error',
                        title: 'Kampanya Eklenmedi',
                        text: 'Boş alanlar doldurulmalı'
                    });
                }
            },
            error: function () {
                Swal.fire({
                    type: 'error',
                    title: 'Kampanya Eklenmedi',
                    text: 'İşlem gerçekleşmedi'
                });
            }
        });
    
    });

//$(document).on("click", "#oyKullan", function () {

//    var degerler = {
//        secilenSecimId: $("#secilenSecimId").val(),
//        secilenAdayId: $("#secilenAdayId").val()
//    };
//    $.ajax({
//        method: 'POST',
//        url: '/OyKullanma/EkleJson',
//        data: JSON.stringify(degerler),
//        dataType: 'JSON',
//        contentType: 'application/json;charset=utf-8',
//        success: function (gelenDeg) {
//            console.log(gelenDeg);

//            if (gelenDeg == "1") {
//                Swal.fire({
//                    type: 'success',

//                    title: 'Oy Kullanıldı',
//                    text: 'İşlem başarıyla gerçekleşti'
//                });
//            }
//            else if (gelenDeg === "bosOlmamalı") {
//                Swal.fire({
//                    type: 'error',
//                    title: 'Oy Eklenmedi',
//                    text: 'Boş alanlar doldurulmalı'
//                });
//            }
//        },
//        error: function () {
//            Swal.fire({
//                type: 'error',
//                title: 'Oy Eklenmedi',
//                text: 'İşlem gerçekleşmedi'
//            });
//        }

//    })
//    return false;
//});

$(document).on("click", "#oyKullan", function () {
    
    var degerler = {
        SecimId: $("#SecimId").val(),
        AdayId: $("#AdayId").val()
        
    };
    $.ajax({
        method: 'POST',
        url: '/OyKullan/EkleJson',
        data: JSON.stringify(degerler),
        dataType: 'JSON',
        contentType: 'application/json;charset=utf-8',
        success: function (gelenDeg) {
            console.log(gelenDeg);
            /*debugger;*/
            if (gelenDeg == "1") {
                Swal.fire({
                    type: 'success',

                    title: 'Oy Eklendi',
                    text: 'İşlem başarıyla gerçekleşti'
                });
            }
            else if (gelenDeg === "bosOlmamalı") {
                Swal.fire({
                    type: 'error',
                    title: 'Oy Eklenmedi',
                    text: 'Boş alanlar doldurulmalı'
                });
            }
        },
        error: function () {
            Swal.fire({
                type: 'error',
                title: 'ERROR',
                text: 'ERROR'
            });
        }

    })
    return false;
});

$(document).on("click", "#giris", function () {
    $(this).html("Kontrol Ediliyor...");
    $(this).prop("disabled", true);

    var degerler = {
        email : $("#email").val(),
        sifre : $("#sifre").val(),
        hatirla : false
    };

    if ($("#checkbox-signup").is(":checked")) {
        degerler.hatirla = true;
    }

    $.ajax({
        type: 'Post',
        url: '/Giris/GirisKontrol',
        data: JSON.stringify(degerler),
        dataType: 'Json',
        contentType: 'application/json;charset=utf-8',
        success: function (gelenDeg) {
            if (gelenDeg == "Başarılı") {
                Swal.fire({ icon: "success", title: "Giriş Başarılı", text: "Yönlendiriliyorsunuz..." });
                window.location.href = '/Secim/Index';
            }
            else if (gelenDeg == "BosOlamaz") {
                Swal.fire({ icon: "error", title: "Giriş Başarısız", text: "Gerekli Alanları Doldurun..." });
            }
            else {
                Swal.fire({ icon: "error", title: "Giriş Başarısız", text: "Hata..." });
            }
        },
        error: function () {
            Swal.fire({ icon: "error", title: "HATA", text: "Hata..." });
        },
        complete: function () {
            $("#giris").html("Giriş Yap");
            $("#giris").prop("disabled", false);
        }
    });
});








