// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

int cocuk_sayisi,maas_hesabi;
int maas = 5500;
Console.WriteLine("Çocuk Sayısını giriniz : " );
cocuk_sayisi = Convert.ToInt32(Console.ReadLine());
if (cocuk_sayisi == 1)
{
    //çocuk sayısı 1 ise maaşa %5 eklenecek
    maas_hesabi = ((maas) + ((maas * 5) / 100));
    Console.WriteLine("Ek maaşınız : "  + maas_hesabi);

}
else if (cocuk_sayisi == 2)
{
    //çocuk sayısı 2 ise maaşa %10 eklenecek
    maas_hesabi = ((maas) + ((maas * 10) / 100));
    Console.WriteLine("Ek maaşınız : " + maas_hesabi);

}
else if (cocuk_sayisi >= 3)
{
    //çocuk sayısı 3 ve daha fazla ise maaşa %15 eklenecek
    maas_hesabi = ((maas) + ((maas * 15) / 100));
    Console.WriteLine("Ek maaşınız : " + maas_hesabi);

}
else
{
    ////çocuk yoksa ya da bekarsa
    Console.WriteLine("Maaşınıza ekleme yapılmayacaktır. ");

}

