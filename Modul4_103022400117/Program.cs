class Program
{
    static void Main(string[] args)
    {
        // KodePaket
        KodePaket kode = new KodePaket();
        string namaPaket = "Gaming";
        Console.WriteLine($"Kode Paket untuk '{namaPaket}' adalah {kode.getKodePaket(namaPaket)}");

        Console.WriteLine();
        // MesinKopi
        MesinKopi mesin = new MesinKopi();
        mesin.MerubahState(MesinKopi.Trigger.POWER_ON);
        mesin.MerubahState(MesinKopi.Trigger.START_BREW);
        mesin.MerubahState(MesinKopi.Trigger.FINISH_BREW);
        mesin.MerubahState(MesinKopi.Trigger.START_MAINTENANCE);
        mesin.MerubahState(MesinKopi.Trigger.FINISH_MAINTENANCE);
        mesin.MerubahState(MesinKopi.Trigger.POWER_OFF);
        mesin.MerubahState(MesinKopi.Trigger.START_MAINTENANCE);

        Console.ReadLine();
    }
}