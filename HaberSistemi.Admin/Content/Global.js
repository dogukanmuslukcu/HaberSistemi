function KategoriEkle() {
    var kategori = {};
    kategori.KategoriAdi = $("#KategoriAdi").val();
    kategori.URL = $("#KategoriUrl").val();
    kategori.AktifMi = $("#KategoriAktif").is(":checked");
    kategori.ParentId = $("#ParentId").val();
    $.ajax({
        url: "/Kategori/Ekle",
        data:kategori,
        type: "POST",
        dataType: "json",
        success: function (response) {
            if (response.Success) {
                bootbox.alert(response.Message, function () {
                    location.reload();
                });
            }
            else {
                bootbox.alert(response.Message, function () {

                });

            }
        }
    });
}