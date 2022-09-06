internal class Program
{
    private static void Main(string[] args)
    {
        //Sort(Siralama)
        int[] sayiDizisi = {23,12,4,86,72,3,11,17};

        Console.WriteLine("**** Sirasiz Liste ****");
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
        
        Console.WriteLine("**** Sirali Liste ****");
        Array.Sort(sayiDizisi);

        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        //Clear : Sıfırlama yapıyor verilen indexten verilen sayi kadar sifirlar
        Console.WriteLine("**** Array Clear ****");
        Array.Clear(sayiDizisi,2,2);

        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
        
        //Reverse : Verilen diziyi ortadan ceviriyor
        Array.Reverse(sayiDizisi);
        Console.WriteLine("**** Array Reverse ****");
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
        
        //IndexOf : Verilen dizide sorulan eleman varsa indexini doner
        Console.WriteLine("**** Array IndexOf ****");
        Console.WriteLine(Array.IndexOf(sayiDizisi,23));

        //Resize : Yeniden boyutlandirma yapar
        Console.WriteLine("**** Array Resize ****");
        Array.Resize<int>(ref sayiDizisi,9);
        sayiDizisi[8] = 99;
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);




    }
}