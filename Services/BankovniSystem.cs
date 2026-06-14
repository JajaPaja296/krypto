using System;
using System.Collections.Generic;
using krypto.Models;

namespace krypto.Services
{
    public class BankovniSystem
    {
        private List<Account> seznamUctu = new List<Account>();

        public void PridatUcet(Account ucet)
        {
            seznamUctu.Add(ucet);
        }

        public Account NajdiUcet(string cisloUctu)
        {
            foreach (var ucet in seznamUctu)
            {
                if (ucet.CisloUctu == cisloUctu)
                {
                    return ucet;
                }
            }
            return null;
        }

        public void VypisVsechnyUcty()
        {
            Console.WriteLine("\n--- SEZNAM VSECH UCTU V BANCOVCE ---");
            foreach (var ucet in seznamUctu)
            {
                ucet.VypisInfo();
            }
            Console.WriteLine();
        }
    }
}