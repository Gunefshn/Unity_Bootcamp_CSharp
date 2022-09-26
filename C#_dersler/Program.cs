
//Dört İşlem
/*double sayi1,sayi2;
Console.WriteLine("Sayi1");
sayi1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Sayi2");
sayi2=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Toplam="+(sayi1+sayi2));
Console.WriteLine("Çıkarma="+(sayi1-sayi2));
Console.WriteLine("Çarpma="+(sayi1*sayi2));
Console.WriteLine("Bölme="+(sayi1/sayi2));

Console.WriteLine("Hangi işlem yapılacak?");
Console.WriteLine("1.Toplama,2.Çıkarma,3.Çarpma,4.Bölme");
int secim = Convert.ToInt32(Console.ReadLine());
if(secim==1){
    Console.WriteLine("Toplam="+(sayi1+sayi2));
}
else if(secim==2){
   Console.WriteLine("Çıkarma="+(sayi1-sayi2)); 
}
else if(secim==3){
    Console.WriteLine("Çarpma="+(sayi1*sayi2));
}
else{
    Console.WriteLine("Bölme="+(sayi1/sayi2));
}
*/

//Yüzde Hesaplama
/*double sayi,yuzde,sonuc;
Console.WriteLine("sayi=");
sayi=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Yüzde=");
yuzde=Convert.ToDouble(Console.ReadLine());

sonuc=sayi*yuzde/100;
Console.WriteLine("Sonuç="+sonuc);
*/

//Dörtgen alan ve çevre hesaplama
/*int kısa_kenar,uzun_kenar,alan,cevre;
Console.WriteLine("Kısa Kenar=");
kısa_kenar=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Uzun kenar=");
uzun_kenar=Convert.ToInt32(Console.ReadLine());

alan=kısa_kenar*uzun_kenar;
cevre=(kısa_kenar*2)+(uzun_kenar*2);

Console.WriteLine("Çevre="+cevre+"alan="+alan);
*/
/*
//Ders Geçme Durumu
double not1,not2,not3,ort;

Console.WriteLine("not1=");
not1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("not2");
not2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("not3=");
not3=Convert.ToDouble(Console.ReadLine());

ort=(not1+not2+not3)/3;

if(ort>50){
    Console.WriteLine("ort="+ort+"Geçtiniz.");
}
else{
    Console.WriteLine("ortalama="+ort+" Kaldınız.");
}
*/
internal class Program
{
    private static void Main(string[] args)
    {
        //Girilen sayilardan büyük olanı bulma 
        /*double sayi1, sayi2;

        Console.WriteLine("Sayi1");
        sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Sayi2");
        sayi2 = Convert.ToDouble(Console.ReadLine());
        if(sayi1<sayi2){
            Console.WriteLine(sayi2+">"+sayi1);
        }
        else{
            Console.WriteLine(sayi1+">"+sayi2);
        }*/


        //Giirilen 5 sayıdan kaç tanesinin belirtilen değerden büyük olduğunu bulma
        /*int sayac=0;
        double sayi,deger;

        Console.WriteLine("deger=");
        deger=Convert.ToDouble(Console.ReadLine());

        for(int x=0;x<5;x++){
            Console.WriteLine("bir sayi giriniz");
            sayi=Convert.ToDouble(Console.ReadLine());
            if(sayi>deger){
                sayac++;
            }

        }
        Console.WriteLine("Girilen sayilardan"+sayac+"adet sayı"+deger+"sayısından büyüktür");
        */
        //Random üretilen sayılar içerisinde çift ve tek sayısını bulma
        int sayi,cift=0,tek=0;
        Random rnd= new Random();
        for(int x=1;x<=10;x++){
            sayi=rnd.Next(1,100);
            Console.WriteLine(sayi);
        }
        if(sayi %2==0){
            cift++;
        }
        else{
            tek++;
        }
        Console.WriteLine("Cift"+cift+" adet sayi,tek"+tek+" adet sayi vardır.");
    }
}