using YardimMasasi.Nesneler.BirimNesneler;

namespace YardimMasasi.IsKatmani.Soyut
{
    public interface IBirimService
    {
        public void BirimEkle(BirimEkleDto birim);
        public BirimGuncelleDto BirimGuncelle(int id, BirimGuncelleDto birimGuncelle);
        public List<BirimListeElemaniDto> GetirBirimListe();
    }
}
