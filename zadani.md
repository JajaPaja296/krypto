# Závěrečný projekt — PRG

**Autor zadání:** David Marek  
**Termín odevzdání:** 27. 5. (upraveno 27. 5.), do **23:59**  
**Hodnocení:** 100 bodů  

> [Odkaz na zadání v Google Classroom](https://classroom.google.com/c/NzgwMzk4MTcyNjc4/a/ODY2MTE2MTk2MDMz/details)

---

## Zadání

Vypracujte **konzolovou aplikaci v jazyce C#** — simulaci bankovního systému.

Projekt staví na látce, kterou jsme probrali během roku — využijete:

- třídy
- dědičnost
- abstraktní třídy
- rozhraní
- kolekce
- výjimky

---

## Společné požadavky

- Aplikace musí používat **třídy** s rozumným rozdělením odpovědností
- Měla by být využita **abstraktní třída** a alespoň **jedno rozhraní**
- **Validace uživatelského vstupu** pomocí `TryParse` — žádné padání programu na špatném vstupu
- **Ošetření výjimek** pomocí `try-catch` tam, kde to dává smysl
- Použití **properties** *(ne veřejných polí)* s vhodnými modifikátory přístupu (`public`, `private`, `protected`)
- Kód rozdělený do **více souborů** — ne všechno v `Program.cs`
- **`README.md`** s popisem aplikace, popisem ovládání *(a případně použitými prompty)*
- **Verzování přes Git** s rozumnou historií commitů — ne jeden commit „final“

---

## Bankovní systém

Vytvořte simulaci bankovního systému — uživatel si může vybrat bankovní účet a provádět nad ním bankovní operace: **vklad**, **výběr** a **převod peněz**.

### Povinné požadavky

- **Abstraktní třída `Account`** s vlastnostmi: číslo účtu, jméno majitele, zůstatek
- Minimálně **dva typy účtů** dědící z `Account`:
  - např. `CheckingAccount` s kontokorentem
  - např. `SavingsAccount` s úrokem
- **Rozhraní** pro operace, které ne každý účet umí *(např. `IOverdraftable` pro kontokorent)*
- **Operace:** vklad, výběr, převod mezi účty, výpis historie
- Třída **`Transaction`** uchovávající datum, typ, částku a zůstatek po operaci
- **Kontokorent** — povolený záporný zůstatek do určitého limitu; výběr nad limit musí vyhodit vlastní výjimku *(např. `InsufficientFundsException`)* a zobrazit uživateli chybovou hlášku
- **Validace:**
  - nelze vložit zápornou částku
  - nelze převést na neexistující účet
  - nelze vybrat víc než povoluje limit

> *Jak budou funkcionality implementované a jak bude simulace fungovat, nechám na vás.*

### Volitelné rozšíření

- Spořicí účet s metodou pro připsání úroku
- Export výpisu do textového souboru ve formě bankovního výpisu
- Simulace času — uživatel může „posunout čas“ o měsíc a uvidí připsané úroky a poplatky
- Statistiky *(celková útrata za měsíc, nejvyšší transakce)*

---

## Hodnocení

| Kritérium | Podíl |
|-----------|-------|
| Správné použití OOP konceptů *(dědičnost, abstrakce, rozhraní, zapouzdření)* | **30 %** |
| Funkcionalita a splnění zadání | **25 %** |
| Validace vstupů a ošetření výjimek | **15 %** |
| Kvalita kódu *(struktura, pojmenování, komentáře, rozdělení do souborů)* | **15 %** |
| README a Git historie | **10 %** |
| Volitelná rozšíření *(bonus)* | až **+10 %** |

---

## Odevzdání

Odevzdejte **odkaz na GitHub repozitář** s projektem.

Repozitář musí obsahovat:

- veškerý zdrojový kód
- `README.md`
- `.gitignore` *(vynechte `bin/` a `obj/` — pro vygenerování použijte `dotnet new gitignore`)*

> **Upozornění:** Projekty bez Git historie nebo bez README nebudou hodnoceny v plném rozsahu.

---

## Použití AI

U tohoto projektu je **povoleno** použití umělé inteligence například při:

- návrhu fungování aplikace
- vysvětlování nových či již probraných témat

### Pokud generujete kód pomocí AI

V `README.md` musí být sekce se:

- seznamem **všech promptů**, které jste použili
- **popisem výstupu**

K aplikacím vygenerovaným pomocí AI bude přistupováno při hodnocení **jinak** — bude potřeba **ústně prokázat**, že kódu rozumíte a umíte reagovat na návrhy na rozšíření.

> Příklad otázky: *„Kdybys chtěl do aplikace X, jak bys to udělal / jak bys nad tím přemýšlel?“*

**Za vygenerovaný kód přebíráte zodpovědnost** a očekává se, že mu budete rozumět.
