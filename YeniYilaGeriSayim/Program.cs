// KAYNAK KOD: https://github.com/kodfun
// KODFUN İLE YENİ YILA GERİ SAYIM

DateTime hedef = new DateTime(
    DateTime.Now.Year + 1, 1, 1);

while (true)
{
    TimeSpan kalan = hedef - DateTime.Now;

    if (kalan.Ticks <= 0)
    {
        Console.WriteLine("MUTLU YILLAR!");
    }
    else
    {
        Console.WriteLine(
            "YENİ YILA KALAN ZAMAN: " +
            Environment.NewLine + 
            kalan.Days +    " GÜN " +
            kalan.Hours +   " SAAT " +
            kalan.Minutes + " DAKİKA " +
            kalan.Seconds + " SANİYE ");
    }

    Thread.Sleep(1000);
    Console.Clear();
}