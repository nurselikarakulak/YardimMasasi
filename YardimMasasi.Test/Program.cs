using YardimMasasi.IsKatmani.Somut;
using YardimMasasi.IsKatmani.Soyut;

namespace YardimMasasi.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISurecService s = new SurecService();

            s.SurecBaslat(new Nesneler.GorevNesneler.Dto.GorevCreateDto
            {
                AltKonuId= 1,
                Email = "email"
            });
        }
    }
}