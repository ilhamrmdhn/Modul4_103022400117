class Program
{
    static void Main(string[] args)
    {
        // KodePaket
        KodePaket kode = new KodePaket();
        string namaPaket = "Gaming";
        Console.WriteLine($"Kode Paket untuk '{namaPaket}' adalah {kode.getKodePaket(namaPaket)}");

        Console.ReadLine();
    }
}