// See https://aka.ms/new-console-template for more information

public class KodePos
{
    public enum Enum_Kelurahan
    {
        Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja
    }

    public static int GetKodePos(Enum_Kelurahan Kelurahan)
    {
        int[] KodePos_Kelurahan = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };

        return KodePos_Kelurahan[(int) Kelurahan];
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Kelurahan & Kode Pos");
        Console.WriteLine("----------------------");
        foreach (Enum_Kelurahan kelurahan in Enum.GetValues(typeof(Enum_Kelurahan)))
        {
            Console.WriteLine($"{kelurahan} - {GetKodePos(kelurahan)}");
        }
    }

}

