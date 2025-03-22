using System;
using System.Text;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread shinkengerThread = new Thread(ShinkengerHenshin);
        Thread decadeThread = new Thread(DecadeHenshin);

        shinkengerThread.Start();
        decadeThread.Start();

        shinkengerThread.Join();
        decadeThread.Join();

        Console.WriteLine("\nTiến lên");
    }


    static void ShinkengerHenshin()
    {
        Console.WriteLine("[*] Ippitsu Sōjō! (一筆奏上)");
        Console.WriteLine("ShinkenRed! Shiba Takeru!");
        Console.WriteLine("ShinkenBlue! Ikenami Ryunosuke!");
        Console.WriteLine("ShinkenYellow! Shiraishi Mako!");
        Console.WriteLine("ShinkenGreen! Tani Chiaki!");
        Console.WriteLine("ShinkenPink! Hanaori Kotoha!");
        Console.WriteLine("ShinkenGold! Umemori Genta!");
        Console.WriteLine("Thiên Hạ Ngự Viễn! (天下御免)");
        Console.WriteLine("Samurai Sentai...");
        Console.WriteLine("Shinkenger!");
        Console.WriteLine("Tham kiến!\n");
    }

    static void DecadeHenshin()
    {
        Thread.Sleep(1000);
        Console.WriteLine("HENSHIN!");
        Console.WriteLine("Kamen Ride");
        Console.WriteLine("DECADE");
        Console.WriteLine("Ta chỉ là một Kamen Rider qua đường mà thôi... Hãy nhớ lấy điều đó!");
        
    }

}
