public class PatikaLibrary
{
    private string _bookName;
    private string _authorName;
    private string _authorSurname;
    private int _pageNumber;
    private string _puslishingHouse;
    private DateTime _recordDate;

    public PatikaLibrary() { _recordDate = DateTime.Now; }

    public PatikaLibrary(string bookName, string authorName, string authorSurname, string publishingHouse, int pageNumber)
    {
        _bookName = bookName;
        _authorName = authorName;
        _authorSurname = authorSurname;
        _pageNumber = pageNumber;
        _puslishingHouse = publishingHouse;
        _recordDate = DateTime.Now;  

    }
    public string BookName
    {
        get { return _bookName; }
        set { _bookName = value; }
    }

    public string AuthorName
    {
        get { return _authorName; }
        set { _authorName = value; }
    }

    public string AuthorSurname
    {
        get { return _authorSurname; }
        set { _authorSurname = value; }
    }

    public int PageNumber
    {
        get { return _pageNumber; }
        set
        {
            if (value > 0)
                _pageNumber = value;
            else
                Console.WriteLine("Geçerli sayafa sayısı girilmedi.");
        }
    }
    public string PublishingHouse
    {
        get { return _puslishingHouse; }
        set { _puslishingHouse = value; }
    }

    public DateTime RecordDate
    {
        get { return _recordDate; }
        set { _recordDate = value; }
    }

    public void RecordingInfo()
    {
        Console.WriteLine($"{_bookName} isimli kitap, {_recordDate} tarihinde kitapliığa eklenmiştir.");
    }

}

// Class : Verileri ve bu veriler üzerinde işlem yapan metotları kapsayan, nesne oluşturma şablonudur. 
// Property: Sınıfın veri üyelerine erişim sağlar.
// New : Sınıf üzerinden yeni bir nesne oluşturmak için kullanılır. 
// Constructor : Oluşturulan nesnenin başlangıç değerlerini ayarlamak için otomatik olarak çağrılan metottur. 