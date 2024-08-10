using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {

        PatikaLibrary book1 = new PatikaLibrary("Adı:Aylin", "Ayşe", "Kulin", "Remzi Kitabevi",398);
        book1.RecordingInfo();

        PatikaLibrary book2 = new PatikaLibrary();
        book2.BookName = "Başka Bir Kitap";
        book2.AuthorName = "Ayşe";
        book2.AuthorSurname = "Karann";
        book2.PublishingHouse = "Beta Yayıncılık";
        book2.PageNumber = 215;
        book2.RecordingInfo();

        PatikaLibrary book3 = new PatikaLibrary("Son Kitap","Elif","Şahin","Delta Yayıncılık", 275);
        book3.RecordingInfo();
    }
}