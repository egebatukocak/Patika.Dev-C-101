using System.Diagnostics.Metrics;
using System.Globalization;
//Ödev:
//1)
//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n)
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar consolea yazdırın

Console.WriteLine("Enter the positive numbers");
Console.Clear();

int positivenumber = 0;

while (positivenumber < 5)
{
    Console.WriteLine("Enter 5 positive numbers");
    int posnumber = Convert.ToInt32(Console.ReadLine());
    positivenumber++;

    Console.WriteLine(posnumber % 2 == 0 ? "Number is Even " + posnumber : "Number is Odd");
}

//2)
//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin
//Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

//int usernumber = 0;

Console.WriteLine("Enter the positive number");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the positive number");
int m = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.WriteLine("Please enter the theree positive number");

while (usernumber < 3)
{
    Console.WriteLine("Enter a positive number:");
    int posnumber = Convert.ToInt32(Console.ReadLine());
    usernumber++;

    if (posnumber == m || posnumber % m == 0)
    {
        Console.WriteLine(posnumber);
    }

    if (posnumber % 2 == 0)
    {
        Console.WriteLine(posnumber);
    }
}

int usernumber = 0;

Console.WriteLine("Enter a positive number for n:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a positive number for m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.WriteLine("Please enter three positive numbers:");

while (usernumber < 1)
{
    Console.WriteLine("Enter a positive number:");
    int posnumber = Convert.ToInt32(Console.ReadLine());
    usernumber++;


    if (posnumber == m || posnumber % m == 0)
    {
        Console.WriteLine($"The number {posnumber} is equal to or divisible by {m}");
    }


    if (posnumber % 2 == 0)
    {
        Console.WriteLine($"The number {posnumber} is divisible by 2");
    }
}

//3)
//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
//Sonrasında kullanıcıdan n adet kelime girmesi isteyin
//Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

Console.WriteLine("Enter Positive Number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please write one sentence");
string sentence = Console.ReadLine();

// Tersine çevirme metodunu çağır
string reversedSentence = ReverseSentence(sentence);

// Tersine çevrilen cümleyi ekrana yazdır
Console.WriteLine(reversedSentence);

static string ReverseSentence(string original)
{
    char[] charArray = original.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

//4)
//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
//Cümledeki toplam kelime ve harf sayısını consolea yazdırın.


    Console.WriteLine("Please write one sentence");
    string sentence = Console.ReadLine();

    Print(sentence);

    Console.ReadLine(); 

static void Print(string sentence)
{
    int kelimeSayisi = NumberCount(sentence, ' ');
    int harfSayisi = NumberCounts(sentence, char.IsLetter);

  
    Console.WriteLine($"Total word count: {kelimeSayisi}");
    Console.WriteLine($"Total letter count: {harfSayisi}");
}

static int NumberCount(string sentence, char separator)
{
    string[] parts = sentence.Split(separator, StringSplitOptions.RemoveEmptyEntries);
    return parts.Length;
}

static int NumberCounts(string metin, Func<char, bool> kriter)
{
    int sayac = 0;
    foreach (char karakter in metin)
    {
        if (kriter(karakter))
            sayac++;
    }
    return sayac;
}