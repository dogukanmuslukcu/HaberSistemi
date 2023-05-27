function KategoriEkle()
{
    Kategori = new Object();
    Kategori.KategoriAdi = $("#KategoriAdi").val();
    Kategori.URL = $("#KategoriUrl").val();
    Kategori.AktifMi = $("#KategoriAktif").is(":checked");
    Kategori.ParentID = $("#ParentID").val();
    alert(Kategori.ParentID);
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