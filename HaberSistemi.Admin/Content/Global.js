function KategoriEkle() {
    var Kategori = {};
    Kategori.KategoriAdi = $("#KategoriAdi").val();
    Kategori.URL = $("#KategoriUrl").val();
    Kategori.AktifMi = $("#KategoriAktif").is(":checked");
    Kategori.ParentId = $("#ParentId").val();
    $.ajax({
        url: "/Kategori/Ekle",
        data: JSON.stringify(Kategori),
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