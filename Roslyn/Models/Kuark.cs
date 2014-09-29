//.NET Compiler Platform("Roslyn")
// Test Model
// azmisahin.com
namespace Roslyn.Models
{
    public enum Tipleri
    { Yukarı, Aşağı, Tılsım, Acayip, Üst, Alt }

    public enum Aileleri
    { Fermiyon, Lepton }

    public enum Semboller
    { q }

    class Kuark(Aileleri aile, Tipleri tip)
    {
        public Aileleri Aile { get; set; } = aile;
        public Tipleri Tip { get; set; } = tip;        
        public Semboller Sembol { get; } = Semboller.q;        

        {
            string name = aile.ToString();
        }
        public Kuark(Aileleri aile) :this(aile,Tipleri.Yukarı)
        {
        }
    }

}
