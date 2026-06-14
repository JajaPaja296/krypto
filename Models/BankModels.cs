using System;

namespace krypto.Models
{
    public interface IOverdraftable
    {
        void VyberSOverdraftem(decimal castka);
    }

    public abstract class Account
    {
        public string CisloUctu { get; set; }
        public string Majitel { get; set; }
        public decimal Zustatek { get; set; }

        public Account(string cisloUctu, string majitel, decimal pocatecniVklad)
        {
            CisloUctu = cisloUctu;
            Majitel = majitel;
            Zustatek = pocatecniVklad;
        }

        public abstract void VypisInfo();

        public void Vlozit(decimal castka)
        {
            if (castka <= 0)
            {
                Console.WriteLine("Chyba: Nelze vlozit zapornou nebo nulovou castku!");
                return;
            }
            Zustatek += castka;
            Console.WriteLine("Uspesne vlozeno: $" + castka + ". Novy zustatek: $" + Zustatek);
        }
    }

    public class SavingsAccount : Account
    {
        public decimal UrokovaSazba { get; set; }

        public SavingsAccount(string cisloUctu, string majitel, decimal vklad) 
            : base(cisloUctu, majitel, vklad)
        {
            UrokovaSazba = 0.02m;
        }

        public override void VypisInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sporici ucet majitele " + Majitel + " (Cislo: " + CisloUctu + ")");
            Console.WriteLine("Zustatek: $" + Zustatek + " | Urok: " + (UrokovaSazba * 100) + "%");
            Console.ResetColor();
        }
    }

    public class CheckingAccount : Account, IOverdraftable
    {
        public decimal LimitPrecerpani { get; set; }

        public CheckingAccount(string cisloUctu, string majitel, decimal vklad) 
            : base(cisloUctu, majitel, vklad)
        {
            LimitPrecerpani = 500m;
        }

        public override void VypisInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bezny ucet majitele " + Majitel + " (Cislo: " + CisloUctu + ")");
            Console.WriteLine("Zustatek: $" + Zustatek + " | Limit precerpani: $" + LimitPrecerpani);
            Console.ResetColor();
        }

        public void VyberSOverdraftem(decimal castka)
        {
            if (castka <= 0)
            {
                Console.WriteLine("Chyba: Neplatna castka pro vyber!");
                return;
            }

            if (Zustatek - castka < -LimitPrecerpani)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Chyba: Nedostatek financi! Prekrocili byste limit kontokorentu.");
                Console.ResetColor();
            }
            else
            {
                Zustatek -= castka;
                Console.WriteLine("Uspesne vybrano: $" + castka + ". Novy zustatek: $" + Zustatek);
            }
        }
    }
}