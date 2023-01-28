namespace Cwiczenia_6_Zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst1 = "jakis       tam    tekst z    mnostwem    spacji";
            string tekst2 = "";
            int licznik = 0;

            while (licznik < tekst1.Length-1)
            {
                if (tekst1[licznik] != ' ' | tekst1[licznik] == ' ' & tekst1[licznik+1] != ' ')
                tekst2 += tekst1[licznik];
                licznik++;

            }
            tekst2 += tekst1[tekst1.Length-1];
            Console.WriteLine(tekst2);

            
        }
    }
}