using System;

interface Ikisi
{
    string adSoyad { get; set; }
    string adres { get; set; }
    public double maas { get; set; }
}
interface IPersonel
{
    //bu propertiesler varsyılan olarak public tanımlı.

    string departman { get; set; }

    void bilgi();
}

class Yonetici : IPersonel, Ikisi
{

    public Yonetici(string adSoyad, string departman, string adres, double maas)
    {
        this.adSoyad = adSoyad;
        this.departman = departman;
        this.adres = adres;
        this.maas = maas;
    }
    public string adSoyad { get; set; }
    public string adres { get; set; }
    public string departman { get; set; }
    public double maas { get; set; }

    public void bilgi()
    {
        Console.WriteLine($"{this.adSoyad} isimli personel {departman} biriminde yöneticidir. Maaşı:{maas} TL dir.");
    }
}

class Iscı : IPersonel, Ikisi
{
    public Iscı(string adSoyad, string departman, string adres, double maas)
    {
        this.adSoyad = adSoyad;
        this.departman = departman;
        this.adres = adres;
        this.maas = maas;
    }
    public string adSoyad { get; set; }
    public string adres { get; set; }
    public string departman { get; set; }
    public double maas { get; set; }

    public void bilgi()
    {
        Console.WriteLine($"{this.adSoyad} isimli personel {departman} biriminde işçidir. Maaşı: {maas} TL dir.");
    }
}

class Robot : IPersonel
{
    public string departman { get;set; }

    public Robot(string departman){
        this.departman=departman;
    }

    public void bilgi()
    {
        Console.WriteLine($"Bu robot {departman} departmanında çalışıyor.");
    }
}
class Program
{
    static void Main(string[] args)
    {

        var personel = new IPersonel[4];
        personel[0] = new Iscı("ali veli", "Yazılım geliştirme", "Mersin", 15000);
        personel[1] = new Yonetici("can", "Yapay zeka", "Ankara", 20000);
        personel[2] = new Iscı("Mehmet", "Siber Güvenlik", "İstanbul", 14500);
        personel[3]= new Robot("Mobil Programlama");

        foreach (var item in personel)
        {
            item.bilgi();
        }
    }
}