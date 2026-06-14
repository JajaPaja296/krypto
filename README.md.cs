/*
# Závěrečný projekt z PRG - Bankovní systém

## Jak to funguje
Projekt plně využívá základy objektově orientovaného programování:
1. Třídy a dědičnost: Máme abstraktní základní třídu `Account` a dva potomky `CheckingAccount` a `SavingsAccount`.
2. Rozhraní (Interface): Využíváme rozhraní `IOverdraftable` pro správu účtů podporujících kontokorent.
3. Validace vstupů: Všechny číselné vstupy od uživatele jsou bezpečně ošetřeny pomocí metody `decimal.TryParse`.

## Ovládání
* list - Zobrazí přehled všech účtů v systému
* info [číslo_účtu] - Vypíše podrobné informace o vybraném účtu
* vklad [číslo_účtu] [částka] - Připíše peníze na účet
* vyber [číslo_účtu] [částka] - Vybere peníze (u běžného účtu s možností jít do mínusu)
* exit - Ukončí program
 * */