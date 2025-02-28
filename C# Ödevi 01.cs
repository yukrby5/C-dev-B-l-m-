using System;

// Temel Araba Sınıfı
class Car
{
    public string Name { get; set; }

    
    public Car(string name)
    {
        Name = name;
    }

    // Vites bilgisini yazdıracak temel metod
    public virtual void Transmission()
    {
        // Boş bırakıyoruz, çünkü her araç kendine özgü vites bilgisini kontrol edecek
    }
}

// BMW sınıfı
class BMW : Car
{
    public BMW(string name) : base(name) { }

    public override void Transmission()
    {
        Console.WriteLine($"{Name} → Düz viteslidir.");
    }
}

// Porsche sınıfı
class Porsche : Car
{
    public Porsche(string name) : base(name) { }

    public override void Transmission()
    {
        Console.WriteLine($"{Name} → Otomatik viteslidir.");
    }
}

// Mercedes sınıfı
class Mercedes : Car
{
    public Mercedes(string name) : base(name) { }

    public override void Transmission()
    {
        Console.WriteLine($"{Name} → Düz viteslidir.");
    }
}

// Togg sınıfı
class Togg : Car
{
    public Togg(string name) : base(name) { }

    public override void Transmission()
    {
        Console.WriteLine($"{Name} → Otomatik viteslidir.");
    }
}

// Audi sınıfı
class Audi : Car
{
    public Audi(string name) : base(name) { }

    public override void Transmission()
    {
        Console.WriteLine($"{Name} → Düz viteslidir.");
    }
}

// Toyota sınıfı
class Toyota : Car
{
    public Toyota(string name) : base(name) { }

    public override void Transmission()
    {
        Console.WriteLine($"{Name} → Otomatik viteslidir.");
    }
}

class Program
{
    static void Main()
    {
        // Araçları oluşturuyoruz
        Car[] cars = {
            new BMW("BMW"),
            new Porsche("Porsche"),
            new Mercedes("Mercedes"),
            new Togg("Togg"),
            new Audi("Audi"),
            new Toyota("Toyota")
        };

        // Her araç için vites türünü ekrana yazdırıyoruz
        foreach (var car in cars)
        {
            car.Transmission();
        }
    }
}


