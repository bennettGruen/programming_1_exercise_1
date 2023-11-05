
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1
        // 1.1
        string zeichenkette = "Das ist meine Zeichenkette.";

        // 1.2
        Console.WriteLine(zeichenkette);

        // 1.3
        Console.Read();

        // 1.4
        string zeichenkette2 = "";
        Console.WriteLine("Bitte Zeichenkette eingeben.");
        zeichenkette2 = Console.ReadLine();

        // 1.5
        Console.WriteLine(zeichenkette + zeichenkette2);



        // 2
        // 2.1
        int zahl1 = 5;
        int zahl2 = 6;

        // 2.2
        int ergebnis;
        ergebnis = zahl1 + zahl2;

        // 2.3
        Console.WriteLine(ergebnis);

        // 2.4
        long ergebnisAddition;
        ergebnisAddition = ergebnis + 2147483647;
        Console.WriteLine(ergebnisAddition);



        // 3
        // 3.1
        int zahlX;
        int zahlY;

        Console.WriteLine("\nBitte Zahl X eingeben.");
        zahlX = int.Parse(Console.ReadLine());

        Console.WriteLine("Bitte Zahl Y eingeben.");
        zahlY = int.Parse(Console.ReadLine());

        // 3.2 - 3.4
        int summe;
        int differenz;
        int produkt;
        float quotient;

        summe = zahlX + zahlY;
        differenz = zahlX - zahlY;
        produkt = zahlX * zahlY;

        if (zahlY != 0)
        {
            quotient = (float)zahlX / zahlY;

            Console.WriteLine("Summe:\n" + summe + "\n"
                + "Differenz:\n" + differenz + "\n"
                + "Produkt:\n" + produkt + "\n"
                + "Quotient:\n" + quotient);
        }
        else
        {
            Console.WriteLine("Division durch 0 nicht möglich.");
        }



        // 4
        double a;
        double b;
        double c;
        double s;
        double F;

        Console.WriteLine("Bitte geben Sie eine Wert für Zahl a ein.");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Bitte geben Sie eine Wert für Zahl b ein.");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Bitte geben Sie eine Wert für Zahl c ein.");
        c = double.Parse(Console.ReadLine());

        // prüfen, ob valides Dreieck
        if ((a + b <= c) || (b + c <= a) || (a + c <= b))
        {
            Console.WriteLine("Die Seitenangaben ergeben kein Dreieck, da eine Seite länger ist als die Summe der anderen beiden Seitenlängen. Satz von Heron nicht anwendbar.");
        }
        else
        {
            s = (a + b + c) / 2;
            F = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine(F);
        }



        // 5
        float rechnungsbetrag;
        int rabattsatz = 0;

        Console.WriteLine("Bitte geben Sie einen Rechnungsbetrag zur Ausgabe des Rabattsatzes an.");
        rechnungsbetrag = float.Parse(Console.ReadLine());

        if (rechnungsbetrag > 5000)
        {
            rabattsatz = 10;
        }
        if (rechnungsbetrag < 5000)
        {
            rabattsatz = 5;
        }
        if (rechnungsbetrag < 2000)
        {
            rabattsatz = 2;
        }
        if (rechnungsbetrag < 500)
        {
            rabattsatz = 0;
        }

        Console.WriteLine("Ihr Rabattsatz beträgt: " + rabattsatz + "%.");



        // 6
        int dienstalter = 0;
        int lebensalter = 0;
        int praemie = 0;

        Console.WriteLine("Bitte geben Sie Ihr Dienstalter in Jahren zur Berechnung der Weihnachtsprämie an.");
        dienstalter = int.Parse(Console.ReadLine());
        Console.WriteLine("Bitte geben Sie ebenfalls Ihr Lebensalter in Jahren an.");
        lebensalter = int.Parse(Console.ReadLine());

        if (dienstalter == 0)
        {
            praemie = 0;
        }

        if ((dienstalter > 0) && (dienstalter < 6))
        {
            praemie = 200;
        }
        else if ((dienstalter >= 6))
        {
            praemie = 80 + (dienstalter * 20);
        }

        if (lebensalter > 50)
        {
            praemie += 50;
        }
        
        // to print €-sign
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Ihre Prämie beträgt: " + praemie + "\u20AC");
    }

}