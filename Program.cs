using System;

class Processor
{
    public string merk;

    public Processor(string merk)
    {
        this.merk = merk;
    }
}

class Intel : Processor
{
    public string tipe;
    public string tipe1;
    public string tipe2;

    public Intel(string merk, string tipe, string tipe1, string tipe2)
        : base(merk)
    {
        this.tipe = tipe;
        this.tipe1 = tipe1;
        this.tipe2 = tipe2;
    }
}

class AMD : Processor
{
    public string tipe;
    public string tipe1;

    public AMD(string merk, string tipe, string tipe1)
        : base(merk)
    {
        this.tipe = tipe;
        this.tipe1 = tipe1;
    }
}

class VGA
{
    public string merk;
    public string merk1;

    public VGA(string merk, string merk1)
    {
        this.merk = merk;
        this.merk1 = merk1;
    }
}

class Laptop : Processor
{
    public string tipe;

    public Laptop(string merk, string tipe)
        : base(merk)
    {
        this.tipe = tipe;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }

    public virtual void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang menjalankan game");
    }
}

class ASUS : Laptop
{
    public ASUS(string merk, string tipe)
        : base(merk, tipe)
    {

    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class Vivobook : ASUS
{
    public string merkVGA;

    public Vivobook(string merkVGA, string merk, string tipeProcessor)
        : base(merkVGA, tipeProcessor)
    {
        this.merkVGA = merkVGA;
        this.merk = merk;
    }
}

class ACER : Laptop
{
    public ACER(string merk, string tipe)
        : base(merk, tipe)
    {

    }

    public override void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo(string merk, string tipe)
        : base(merk, tipe)
    {
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad(string merkVGA, string tipeProcessor)
    : base(merkVGA, tipeProcessor)
    {
    }
}

class Predator : Laptop
{
    public Predator(string merk, string tipe)
        : base(merk, tipe)
    {
    }

    public override void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook("Nvidia", "Intel", "Core i5");
        Laptop laptop2 = new IdeaPad("AMD", "Ryzen");
        Predator predator = new Predator("AMD", "Core i7");
        ACER acer = predator; 

        laptop1.Ngoding();

        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        Console.WriteLine($"Spesifikasi laptop1: Merk VGA : {((Vivobook)laptop1).merkVGA}, Merk Processor: {laptop1.merk}, Tipe Processor : {laptop1.tipe}");

        predator.BermainGame(); 

        acer.BermainGame(); 

        Console.ReadLine();
    }
}


