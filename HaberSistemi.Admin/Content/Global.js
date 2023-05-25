function KategoriEkle()
{
    Kategori = new Object();
    Kategori.KategoriAdi = $("#kategoriAdi").val();
    Kategori.URL = $("#kategoriUrl").val();
    Kategori.AktifMi = $("#kategoriAktif").is(":checked");

    $.ajax({
        url: "Kategori/Ekle",
        data: Kategori,
        type: "POST",
        success: function (response)
        {
            if (response.success) {
                bootbox.alert(response.Message, function () {
                    location.reload();
                });
            } else
            {
                bootbox.alert(response.Message, function () {

                });
            }
        }
    })
}