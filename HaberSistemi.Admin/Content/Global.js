function KategoriEkle()
{
    Kategori = new Object();
    Kategori.KategoriAdi = $("#kategoriAdi").val();
    Kategori.URL = $("#kategoriUrl").val();
    Kategori.AktifMi = $("#kategoriAktif").is(":checked");
    alert(Kategori.KategoriAdi + Kategori.URL + Kategori.AktifMi);

    $.ajax({
        url: "Kategori/Ekle",
        data: Kategori,
        type: "POST",
        success: function (response)
        {
            if (response.success) {
                alert(1);
            } else
            {
                alert(2);
            }
        }
    })
}