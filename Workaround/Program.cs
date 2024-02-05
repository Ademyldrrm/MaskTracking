// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//string mesaj = "Merhaba";
//double tutar = 100000;
//int sayi = 100;
//bool girisYapmisMi = true;
//string ad = "Adem";
//string soyad = "Yıldırım";
//int dogumYili = 2000;
//long tcNo = 12345678910;
using Business.Concrete;
using Entities.Concrete;

Vatandas vatandas1 = new Vatandas();
vatandas1.Ad = "Adem";


Person person = new Person();
person.FirstName = "Adem";
person.LastName = "YILDIRIM";
person.DateOfBirthYear = 2000;
person.NationalIdentity = 123;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);






public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string DoğumYili { get; set; }
    public string TcNo { get; set; }

}



