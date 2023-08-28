using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Nesneler.AnaKonuNesneler.Dto;

namespace YardimMasasi.IsKatmani.Somut
{
    public class AnaKonuService : IAnaKonuService
    {
        public void AnaKonuEkle(AnaKonuEkleDto anaKonu)
        {
            throw new NotImplementedException();
        }

        public AnaKonuGuncelleDto AnaKonuGuncelle(int id, AnaKonuGuncelleDto anaKonu)
        {
            throw new NotImplementedException();
        }

        public List<AnaKonuListeElemaniDto> GetirAnaKonuListe()
        {
            var liste = new List<AnaKonuListeElemaniDto>();

            var k1 = new AnaKonuListeElemaniDto();
            var k2 = new AnaKonuListeElemaniDto();
            var k3 = new AnaKonuListeElemaniDto();
            var k4 = new AnaKonuListeElemaniDto();
            var k5 = new AnaKonuListeElemaniDto();
            k1.Id = 1;
            k1.Konu = "Mail Sorunları";
            k2.Id = 2;
            k2.Konu = "İletişim Sorunları";
            k3.Id = 3;
            k3.Konu = "Oturma Sorunları";
            k4.Id = 4;
            k4.Konu = "Ekipman Sorunları";
            k5.Id = 5;
            k5.Konu = "İnşaat Sorunları";

            liste.AddRange(new[] { k1, k2, k3, k4, k5 });


            return liste;
        }
    }
}
