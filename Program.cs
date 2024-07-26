
// 1 . Sorunu çözümü
System.Console.WriteLine("1) soru çözümü");
System.Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");


// 2.Sorunun çözümü
System.Console.WriteLine("2) soru çözümü");
string text = "merhaba";
int number = 100;
System.Console.WriteLine("Tam sayi: " + number + "\n" + "Metin: " + text);


// 3.soru çözümü
System.Console.WriteLine("3) soru çözümü");

Random rnd = new Random();
int randomNumber = rnd.Next();
System.Console.WriteLine("Rastgelen sayi: " + randomNumber);


// 4.soru çözümü
System.Console.WriteLine("4) soru çözümü");

Random rnd1 = new Random();
int randomSayi = rnd1.Next();
int kalan = randomSayi % 3;
System.Console.WriteLine("Random sayinin 3 bölümünden kalan: " + kalan);


// 5. soru çözüm
System.Console.WriteLine("5) soru çözümü");

System.Console.Write("Lütfen yaşınızı giriniz: ");
int age= Convert.ToInt32(Console.ReadLine());

if (age <18)
{
    System.Console.WriteLine("-");
}
else if (age > 18)
{
    System.Console.WriteLine("+");
}
else System.Console.WriteLine("18 yaşında");


// 6. soru çözüm
System.Console.WriteLine("6) soru çözümü");

for(int i=0;i<10;i++)
{
    System.Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}


// 7 .Soru çözümü soruyu anlamadım !!!
System.Console.WriteLine("7) soru çözümü");

System.Console.Write("1.Metini giriniz: ");
string text1 = Console.ReadLine();
System.Console.Write("2.Metini giriniz: ");
string text2 = Console.ReadLine();
string temporary= string.Empty;

temporary=text1;
text1=text2;
text2=temporary;
System.Console.WriteLine("Yer değiştirldi.");
System.Console.WriteLine("1. Metin: " + text1);
System.Console.WriteLine("2.Metin: " + text2);


// 8. soru çözüm
System.Console.WriteLine("8) soru çözümü");

static void BenDegerDondurmem() 
{
    System.Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" );
}
BenDegerDondurmem();


// 9. soru çözüm
System.Console.WriteLine("9) soru çözümü");

System.Console.WriteLine("Toplamak için iki sayi giriniz.\n1.sayi: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("2.sayi: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Toplam: {Toplam(number1,number2)}");

static int Toplam(int x , int y) 
{
    return x+y;
}


// 10. soru çözüm
System.Console.WriteLine("10) soru çözümü");

string text3 = ReturnText(true);
System.Console.WriteLine(text3);

static string ReturnText(bool x)
{
    if(x)
        return "Anlat";
    else
        return "Anlatma";
}


// 11. soru çözümüm
System.Console.WriteLine("11) soru çözümü");

System.Console.WriteLine("Lütfen 3 yaş giriniz!\n1.Yas: ");
int age1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("2. Yas: ");
int age2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("3. Yas: ");
int age3 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("En büyük yas: " + (Elder(age1,age2,age3)));

static int Elder(int s1 ,int s2 , int s3)
{

    if(s1>s2 && s1>s3)   
        return s1;
    
    else if (s2 > s1 && s2 > s3)
        return s2;      

    else
        return s3;
    

}

// 12. soru çözümü !!!

System.Console.WriteLine("12) soru çözümü");

GetNumbersFindMaxNumber();

static int GetNumbersFindMaxNumber()
{
    int counter=0;
    int maxNumber=0;
    System.Console.Write("Çıkmak için q tuşuna basınız \nSayı giriniz: ");
    
    while(true)
    {

        string input = Console.ReadLine();

        if (input =="q")
        {
            break;
        }

        int number=Convert.ToInt32(input);
        if(counter ==0)
        {
            maxNumber = number;
            System.Console.WriteLine("En büyük sayi: " + maxNumber);
            counter++;
            
        }
        else
        {
            if (maxNumber >= number)
            {
                System.Console.WriteLine("En büyük sayi: " + maxNumber);
                counter++;
                
            }
            else
            {
                maxNumber=number;
                System.Console.WriteLine("En büyük sayi: " + maxNumber);
                counter++;
                
            }
        }

    }
    return maxNumber;
}



// 13. soru çözümü
System.Console.WriteLine("13) soru çözümü");

SwapName();

static void SwapName()
{
    string temporaryName= string.Empty;
    System.Console.Write("1. İsmi giriniz: ");
    string name1 = Console.ReadLine();
    System.Console.WriteLine("2. İsmi giriniz: ");
    string name2 = Console.ReadLine();

    temporaryName = name1;
    name1=name2;
    name2=temporaryName;

    System.Console.WriteLine("Yeni 1. isim: " + name1);
    System.Console.WriteLine("Yeni 2. isim: " + name2);

}


// 14. soru çözümü
System.Console.WriteLine("14) soru çözümü");

System.Console.Write("Sayi: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (EvenOrOdd(number3))
{
    System.Console.WriteLine("Sayi çift.");
}
else System.Console.WriteLine("Sayi tek.");

static bool EvenOrOdd(int x)
{
    if (x%2 == 0)
    {
        return true;
    }
    return false;
}


// 15. soru çözümü
System.Console.WriteLine("15) soru çözümü");

System.Console.Write("Lütfen hızınızı giriniz(km/h): ");
int speed = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Lütfen sürenizi giriniz(Dk): ");

int minute = Convert.ToInt32(Console.ReadLine());

float distance = (float)(speed / 60.0f) * (float)minute;
System.Console.WriteLine("Gidilen yol(km): " + distance + " Km");



// 16. soru çözümü 
System.Console.WriteLine("16) soru çözümü");

const double pi = 3.14;

System.Console.Write("Lütfen bir yarıçap giriniz(cm): ");
int radius = Convert.ToInt32(Console.ReadLine());

double field = pi * (double)Math.Pow(radius,2);

System.Console.WriteLine("Dairenin alanı: " + field);



// 17. soru çözümü
System.Console.WriteLine("17) soru çözümü");
string text4 = "Zaman bir GeRi SayIm";
System.Console.WriteLine("Hepsi küçük: " + text4.ToLower());
System.Console.WriteLine("Hepsi büyük: " + text4.ToUpper());



// 18. soru çözüm
System.Console.WriteLine("18) soru çözümü");
string text5 = "    Selamlar   ";
string trimText = text5.Trim();
System.Console.WriteLine("Yeni hali:" + trimText);


