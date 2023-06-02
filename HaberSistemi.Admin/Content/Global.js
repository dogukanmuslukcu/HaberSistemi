function KategoriEkle()
{
    Kategori = new Object();
    Kategori.KategoriAdi = $("#kategoriAdi").val();
    Kategori.URL = $("#kategoriUrl").val();
    Kategori.AktifMi = $("#kategoriAktif").is(":checked");
    Kategori.ParentId = $("#ParentId").val();
    alert(Kategori.ParentId);
    $.ajax({
        url: "/Kategori/Ekle",
        data: Json.stringify(Kategori),
        type: "POST",
        dataType:"json",
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