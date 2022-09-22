using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace TugasPraktikum
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Ban Michelin = new Michelin();
            Ban Brigestone = new Brigestone();

            Mobil mobil1 = new Ayga(Michelin);
            Mobil mobil2 = new Avanza(Brigestone);

            Civic civic1 = new Civic(Brigestone);

            //soal no 1
            mobil1.NyalakanMesin();
            mobil1.MatikanMesin();

            //Soal no 2
            ((Avanza)mobil2).NyalakanLampu();

            //soal 3
            Console.WriteLine(mobil1.ban);

            //soal 4
            civic1.VtecKickedln();

            //soal 5
            Honda honda1 = civic1;
            ((Civic)honda1).VtecKickedln();

        }
    }
}

class Mobil
{
    public string merk, tipe;
    public Ban ban;

    public Mobil(string merk, string tipe, Ban ban)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.ban = ban;
    }

    public void NyalakanMesin()
    {
        Console.WriteLine($"Mesin mobil {this.merk} bertipe {this.tipe} menyala.");
    }
    public void MatikanMesin()
    {
        Console.WriteLine($"Mesin mobil {this.merk} bertipe {this.tipe} mati.");
    }

}
class Toyota : Mobil
{
    public Toyota(string tipe, Ban ban) : base("Toyota", tipe, ban)
    {

    }
}
class Daihatsu : Mobil
{
    public Daihatsu(string tipe, Ban ban) : base("Daihatsu", tipe, ban)
    {
    }
}
class Honda : Mobil
{
    public Honda(string tipe, Ban ban) : base("Honda", tipe, ban)
    {

    }
}
class Ayga : Toyota
{
    public Ayga(Ban ban) : base("Ayga", ban)
    {
    }
}
class Innova : Toyota
{
    public Innova(Ban ban) : base("Innova", ban)
    {

    }
}
class Avanza : Toyota
{
    public Avanza(Ban ban) : base("Avanza", ban)
    {

    }

    public void NyalakanLampu()
    {
        Console.WriteLine($"Lampu mobil {this.merk} bertipe {this.tipe} menyala. ");
    }

}

class Ayla : Daihatsu
{
    public Ayla(Ban ban) : base("Ayla", ban)
    {

    }
}

class Xenia : Daihatsu
{
    public Xenia(Ban ban) : base("Xenia", ban)
    {

    }

}

class Brio : Honda
{
    public Brio(Ban ban) : base("Brio", ban)
    {

    }
}
class Civic : Honda
{
    public Civic(Ban ban) : base("Civic", ban)
    {

    }
    public void VtecKickedln()
    {
        Console.WriteLine("Ngeeeng Wooosh!!!");
    }
}

class Ban
{
    public string merk;

    public Ban(string merk)
    {
        this.merk = merk;
    }
}
class Michelin : Ban
{
    public Michelin() : base("Michelin")
    {
    }
}
class Brigestone : Ban
{
    public Brigestone() : base("Bridgestone")
    {

    }
}