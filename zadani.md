https://classroom.google.com/c/NzgwMzk4MTcyNjc4/a/ODY2MTE2MTk2MDMz/details

Závěrečný projekt
David Marek
•
27. 5. (Upraveno 27. 5.)
100 bodů
Termín odevzdání: 23:59
Vyberte si jedno z níže uvedených zadání a vypracujte konzolovou aplikaci v jazyce C#. Všechna zadání staví na látce, kterou jsme probrali během roku - využijete třídy, dědičnost, abstraktní třídy, rozhraní, kolekce, výjimky a v některých případech i práci s API.

Společné požadavky (platí pro všechna zadání)
Aplikace musí používat s rozumným rozdělením odpovědností
Měla by být využita a alespoň jedno nebo (záleží na zadání)
Validace uživatelského vstupu pomocí TryParse (žádné padání programu na špatném vstupu)
Ošetření výjimek pomocí try-catch tam, kde to dává smysl
Použití (ne veřejných polí) s vhodnými modifikátory přístupu (public, private, protected)
Kód rozdělený do více souborů (ne všechno v Program.cs)
README.md s popisem aplikace, popisem ovládání (a případně použitými prompty)
Verzování přes s rozumnou historií commitů (ne jeden commit "final")
Zadání 1 - Aplikace s externím API
Vytvořte konzolovou aplikaci, která komunikuje s veřejným API a zobrazuje uživateli užitečná data.

Příklady témat:
Počasí - Open-Meteo (bez API klíče), zobrazení aktuálního počasí a předpovědi pro zadané město
Kryptoměny - CoinGecko, ceny mincí, historie, porovnání
Filmy - OMDb nebo TMDB, vyhledávání filmů, detaily, hodnocení
Nebo vlastní API
Povinné požadavky:
Využití HttpClient (jedna sdílená instance, ne nová pro každý požadavek)
Asynchronní metody s async / await / Task
Deserializace JSON pomocí System.Text.Json do vlastních tříd nebo recordů
REPL rozhraní podobně jako Pokedex — uživatel zadává příkazy (např. search, details, help, exit)
Minimálně s různou funkcionalitou
Ošetření chyb sítě (výpadek internetu, neplatná odpověď, neexistující záznam) pomocí try-catch
Volitelné rozšíření:
Uchování stavu mezi příkazy (např. historie vyhledávání, naposledy zobrazený záznam)
Uložení výstupu některého z příkazů do souboru
Cachování odpovědi API pro optimalizaci
Zadání 2 - Hra v konzoli
Vytvořte hru hratelnou v konzoli.

Příkady her:
Textová adventura s místnostmi, inventářem a hádankami
Had (Snake) s vykreslováním přes Console.SetCursorPosition
Black Jack proti počítači
Tahová RPG hra s více postavami, nepřáteli a inventářem (rozšíření cvičení o RPG)
Šibenice hádací slovní hra
Povinné požadavky:
Minimálně 4 vlastní třídy s rozumným rozdělením odpovědností (např. Game, Player, Board, Enemy)
Použití dědičnosti (např. různé typy postav, nepřátel, karet, předmětů)
Použití abstraktní třídy nebo rozhraní pro definici společného chování
Herní smyčka s jasnými ukončovacími podmínkami
Validace všech vstupů od hráče
Volitelné rozšíření:
Použití barev v konzoli (Console.ForegroundColor)
Statistiky odehraných her
Zadání 3 - Bankovní systém
Vytvořte simulaci bankovního systému - uživatel si může vybrat bankovní účet a provádět nad ním bankovní operace - vklad, výběr a převod peněz.

Povinné požadavky:
Abstraktní třída Account s vlastnostmi jako číslo účtu, jméno majitele, zůstatek
Minimálně dva typy účtů dědící z Account (např. CheckingAccount s kontokorentem, SavingsAccount s úrokem)
Rozhraní pro operace, které ne každý účet umí (např. IOverdraftable pro kontokorent)
Operace: vklad, výběr, převod mezi účty, výpis historie
Třída Transaction uchovávající datum, typ, částku a zůstatek po operaci
Kontokorent - povolený záporný zůstatek do určitého limitu, výběr nad limit musí vyhodit vlastní výjimku (např. InsufficientFundsException) a zobrazit uživateli chybovou hlášku
Validace: nelze vložit zápornou částku, převést na neexistující účet, vybrat víc než povoluje limit
(To jak budou popsané funkcionality implementované a jak bude simulace fungovat nechám na vás)

Volitelné rozšíření:
Spořicí účet s metodou pro připsání úroku
Export výpisu do textového souboru ve formě bankovního výpisu
Simulace času — uživatel může "posunout čas" o měsíc a uvidí připsané úroky a poplatky
Statistiky (celková útrata za měsíc, nejvyšší transakce)
Zadání 4 - Správce úkolů (TODO aplikace)
Vytvořte aplikaci pro správu osobních úkolů s perzistencí dat.

Povinné požadavky:
Třída TaskItem s vlastnostmi: název, popis, priorita (), stav (hotový/nehotový)
s příkazy jako add, list, done, delete, help, exit
Ukládání do souboru (JSON), aby data přežila restart
Ošetření neplatných operací (např. úkol s daným ID neexistuje)
Volitelné rozšíření:
Filtrování úkolů podle stavu, priority
Řazení úkolů (podle priority, abecedy)
Použití pro filtrování a řazení (Where, OrderBy)
Statistiky (kolik máte splněných úkolů)
Hodnocení
Správné použití OOP konceptů (dědičnost, abstrakce, rozhraní, zapouzdření) - 30 %
Funkcionalita a splnění zadání - 25 %
Validace vstupů a ošetření výjimek - 15 %
Kvalita kódu (struktura, pojmenování, komentáře, rozdělení do souborů) - 15 %
README a Git historie - 10 %
Volitelná rozšíření (bonus) - až +10 %
Odevzdání
Odevzdejte odkaz na GitHub repozitář s projektem. Repozitář musí obsahovat veškerý zdrojový kód, README.md a .gitignore (vynechte bin/ a obj/ - pro vygenerovaní .gitignore můžete použít `dotnet new gitignore`). Projekty bez Git historie nebo bez README nebudou hodnoceny v plném rozsahu.

Použití AI
U tohoto projektu je povoleno použití umělé inteligence například při návrhu fungování aplikace nebo pro vysvětlování nových či již probraných témat.

Pokud se rozhodnete pomocí AI generovat i samotný kód, chci abyste v README.md měli sekci se seznamem všech promptů, které jste použili + popis výstupu. K aplikacím vygenerovaným pomocí AI bude přistupováno při hodnocení jinak a bude potřeba ústně prokázat, že kódu rozumíte a umíte reagovat na návrhy na rozšíření (otázky typu: "Kdybys chtěl do aplikace X, jak bys to udělal/jak bys nad tím přemýšlel?"). Za vygenerovaný kód přebíráte zodpovědnost a očekávám, že mu budete rozumět.
