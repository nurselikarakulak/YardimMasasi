using YardimMasasi.Nesneler.AnaKonuNesneler.Dto;

namespace YardimMasasi.IsKatmani.Soyut
{
    public interface IAnaKonuService
    {
        public void AnaKonuEkle(AnaKonuEkleDto anaKonu);
        public AnaKonuGuncelleDto AnaKonuGuncelle(int id, AnaKonuGuncelleDto anaKonu);
        public List<AnaKonuListeElemaniDto> GetirAnaKonuListe();

    }


}
