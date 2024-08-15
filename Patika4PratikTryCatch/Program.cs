
//While döngüsü ,çin değişken tanımalama
bool exit = false;
while (!exit)
{//Kullanıcıdan veri girişi isteme 
    Console.WriteLine("Bir sayı giriniz");
    string input = Console.ReadLine();
    try
    {
        //Girilen verinin int değişkenine çevirme
        int number = int.Parse(input);
        //Girilen verinin karesinin alınması
        int square = number * number;
        Console.WriteLine("Girmiş olduğunuz sayının karesi:" + square);

        exit = true;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
    }
    finally
    {

    }
}
Console.WriteLine("Teşekkürler");