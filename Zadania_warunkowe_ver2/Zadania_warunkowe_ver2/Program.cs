void Zadanie1()
    {
    /*1.
    Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są
    one równe czy nie.
    Dane testowe:
    a: 5
    b: 5
    Rezultat w terminalu :
    5 i 5 są równe
    */
    Console.WriteLine("Podaj liczbe a");
    string ?a = Console.ReadLine();

    Console.WriteLine("Podaj liczbe b");
    string ?b = Console.ReadLine();

    Int32.TryParse(a, out var aInt);
    Int32.TryParse(b, out var bInt);

    if (aInt == bInt)
        Console.WriteLine(aInt + " i " + bInt + " są równe");
    else
        Console.WriteLine(aInt + " nie jest równe " + bInt);

    }

void Zadanie2()
{
    /*
    Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
    jest parzysta czy nieparzysta.
    Dane testowe : 15
    Rezultat w terminalu :
    15 jest liczbą nieparzystą

     */

    Console.WriteLine("Podaj liczbe do sprawdzenia czy jest parzysta:");
    string liczbaString = Console.ReadLine();

    Int32.TryParse(liczbaString, out var liczbaInt);
    int moduloDzielenia = liczbaInt % 2;

    if (moduloDzielenia == 0)
        Console.WriteLine("Liczba " + liczbaInt + " jest parzysta");
    else
        Console.WriteLine("Liczba " + liczbaInt + " jest nie parzysta");

}

void Zadanie3()
{
    /*
     3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
    jest dodatnia czy ujemna.
    Dane testowe : 14
    Rezultat w terminalu :
    14 jest liczbą dodatnią
     */
    Console.WriteLine("Podaj liczbe do sprawdzenia czy jest dodatnia:");
    string liczbaString = Console.ReadLine();

    Int32.TryParse(liczbaString, out var liczbaInt);

    int numberChectPositiv = liczbaInt * -1;

    if (numberChectPositiv < liczbaInt)
        Console.WriteLine("Podana liczba " + liczbaInt + " jest parzysta");
    else
        Console.WriteLine("Podana liczba " + liczbaInt + " NIE jest parzysta");

}

void Zadanie4()
{
    /*
     4. Napisz program w C#, który sprawdzi czy podany przez użytkownika rok
    jest rokiem przestępnym.
    Dane testowe : 2016
    Rezultat w terminalu :
    2016 jest rokiem przestępnym
     */
    int rokPrzystepnyConsta = 2016;

    Console.WriteLine("Podaj rok:");
    string liczbaString = Console.ReadLine();

    Int32.TryParse(liczbaString, out var liczbaInt);

    // sprawdzanie czy liczba jest parzysta
    int roznicaLat = liczbaInt - rokPrzystepnyConsta;
    int moduloRoznicaLat = roznicaLat % 4;

    if ((moduloRoznicaLat == 0) || (liczbaInt == 2016))
        Console.WriteLine(liczbaInt  + " jest rokiem przystepnym");
    else
        Console.WriteLine(liczbaInt + " NIE jest rokiem przystepnym");

}

void Zadanie5()
{
    /*
     5. Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek
    uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,
    prezydenta.
    Dane testowe : 21
    Rezultat w terminalu :
    Możesz zostać posłem
     */
        Console.WriteLine("Podaj swój wiek:");
        string liczbaString = Console.ReadLine();

        Int32.TryParse(liczbaString, out var liczbaInt);
    if (liczbaInt >= 35)
        Console.WriteLine("Możesz kandydować na prezydenta, senatora i do sejmu");
    else if (liczbaInt >= 30)
        Console.WriteLine("Możesz kandydować na senatora i do sejmu");
    else if (liczbaInt >= 25)
        Console.WriteLine("Możesz kandydować do sejmu");
    else
        Console.WriteLine("Nie mozesz być przy wladzy dzieciaku");

}

void Zadanie6()
{
    /*
    6. Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu
    wymyśloną kategorię wzrostu.
    Dane testowe : 140
    Rezultat w terminalu :
    Jesteś krasnoludem
     */
    Console.WriteLine("Podaj swój wzrost w centymetrach:");
    string ?liczbaString = Console.ReadLine();

    Int32.TryParse(liczbaString, out var liczbaInt);

    if (liczbaInt >= 200)
        Console.WriteLine("Z tym wzrostem idz grać w kosza");
    else if (liczbaInt >= 170)
        Console.WriteLine("Jestes normalnego wzrostu");
    else
        Console.WriteLine("nie ustawiles sie w kolejce po wzrost");

        
}

string wyjscieZPetli="cos";
string Zadanie7()
{
    /*
    7. Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi,
    która jest największa
    Dane testowe:
    25
    63
    79
    Rezultat w terminalu :
    79 jest największa z podanych
     */

    
    Console.WriteLine("Podaj liczbe a:");
    string liczbaAString = Console.ReadLine();

    Int32.TryParse(liczbaAString, out var liczbaAInt);

    Console.WriteLine("Podaj liczbe b:");
    string liczbaBString = Console.ReadLine();

    Int32.TryParse(liczbaBString, out var liczbaBInt);

    Console.WriteLine("Podaj liczbe c:");
    string liczbaCString = Console.ReadLine();
    Int32.TryParse(liczbaCString, out var liczbaCInt);

    if ((liczbaAInt > liczbaBInt && (liczbaAInt > liczbaCInt)))
        Console.WriteLine("Liczba " + liczbaAInt + " jest największa");
    else if ((liczbaBInt > liczbaCInt) && (liczbaBInt > liczbaAInt))
        Console.WriteLine("Liczba " + liczbaBInt + " jest największa");
    else if ((liczbaCInt > liczbaAInt) && (liczbaCInt > liczbaBInt))
        Console.WriteLine("Liczba " + liczbaCInt + " jest największa");
    else
        Console.WriteLine("W podanych liczbach nie ma jednej najwiekszej liczby");

    if (liczbaAString == "x" || liczbaBString == "x" || liczbaCString == "x")
        wyjscieZPetli = "x";
    else
        wyjscieZPetli = "continue";

    return wyjscieZPetli;
}

void Zadanie8()
{
    /*
    8. Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce
    na studiach wg. Następujących kryteriów:
    Wynik z Matury z matematyki powyżej 70
    Wynik z fizyki powyżej 55
    Wynik z chemii powyżej 45
    Łączny wynik z 3 przedmiotów powyżej 180
    Albo
    Wynik z matematyki i jednego przedmiotu powyżej 150
    Dane testowe:
    Matematyka 80
    Fizyka 71
    Chemia 0
    Rezultat w terminalu :
    Kandydat dopuszczony do rekrutacji

     */
    Console.WriteLine("Podaj ocene z matmy:");
    string liczbaAString = Console.ReadLine();

    Int32.TryParse(liczbaAString, out var liczbaAInt);

    Console.WriteLine("Podaj ocene z fizyki:");
    string liczbaBString = Console.ReadLine();

    Int32.TryParse(liczbaBString, out var liczbaBInt);

    Console.WriteLine("Podaj ocene z chemi:");
    string liczbaCString = Console.ReadLine();
    Int32.TryParse(liczbaCString, out var liczbaCInt);

    if ((liczbaAInt + liczbaBInt >= 150) || (liczbaAInt + liczbaCInt >= 150) || (liczbaAInt + liczbaBInt + liczbaCInt >= 180))
        Console.WriteLine("Zostales zakwalifikowany");
    else
        Console.WriteLine("Masz za malo punktów");
}

void Zadanie9()
{
    /*
     Napisz program, który odczyta temperaturę I zwróci nazwę jak w
    poniższych kryteriach
    Temp < 0 – cholernie piździ
    Temp 0 – 10 – zimno
    Temp 11 – 20 – chłodno
    Temp 21 – 30 – w sam raz
    Temp 31 – 40 – zaczyna być słabo, bo gorąco
    Temp >= 40 – a weź wyprowadzam się na Alaskę.
    Dane testowe : 41
    Rezultat w terminalu :
    a weź wyprowadzam się na Alaskę.
     */
    Console.WriteLine("Podaj temperature:");
    string liczbaString = Console.ReadLine();

    Int32.TryParse(liczbaString, out var liczbaInt);

    if (liczbaInt >= 40)
        Console.WriteLine("a weź wyprowadzam się na Alaskę.");
    else if (liczbaInt > 30)
        Console.WriteLine("zaczyna być słabo, bo gorąco");
    else if (liczbaInt > 20)
        Console.WriteLine("w sam raz");
    else if (liczbaInt > 10)
        Console.WriteLine("Chlodno");
    else if (liczbaInt > 0)
        Console.WriteLine("zimno");
    else
        Console.WriteLine("cholernie piździ");

}

void Zadanie10()
{/*
    10.Napisz program, który sprawdzi, czy z 3 podanych długości można
    stworzyć trójkąt
    Dane testowe: 40 55 65
    Rezultat w terminalu:
    Można zbudować trójkąt
    Aby z trzech odcinków zbudować trójkąt, najdłuższy z nich musi być krótszy niż suma długość dwóch pozostałych. 
*/
    Console.WriteLine("Podaj dlugosc a:");
    string liczbaAString = Console.ReadLine();

    Int32.TryParse(liczbaAString, out var liczbaAInt);

    Console.WriteLine("Podaj dlugosc b:");
    string liczbaBString = Console.ReadLine();

    Int32.TryParse(liczbaBString, out var liczbaBInt);

    Console.WriteLine("Podaj dlugosc c:");
    string liczbaCString = Console.ReadLine();
    Int32.TryParse(liczbaCString, out var liczbaCInt);

    // obliczanie sumy najdluzszego boku
    int theLargestSite1 = liczbaAInt + liczbaBInt;
    int theLargestSite2 = liczbaBInt + liczbaCInt;
    int theLargestSite3 = liczbaAInt + liczbaCInt;

    int najdluzszaDlugosc=0;

    if ((liczbaAInt > liczbaBInt && (liczbaAInt > liczbaCInt)))
        najdluzszaDlugosc = 1;
    else if ((liczbaBInt > liczbaCInt) && (liczbaBInt > liczbaAInt))
        najdluzszaDlugosc = 2;
    else if ((liczbaCInt > liczbaAInt) && (liczbaCInt > liczbaBInt))
        najdluzszaDlugosc = 3;
    

    if (((liczbaAInt < theLargestSite2) && (najdluzszaDlugosc == 1)) || 
         ((liczbaBInt < theLargestSite3) && (najdluzszaDlugosc == 2)) || 
         ((liczbaCInt < theLargestSite1 && (najdluzszaDlugosc == 3))))
        Console.WriteLine("Z tych dlugosci mozesz zbudowac trojkat");
   
    else
        Console.WriteLine("Nie zbudujesz trojkata");
}

void Zadanie12()
{
    /*
    11. Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
    Ocena Opis
    6 Celujący
    5 Bardzo dobry
    4 Dobry
    3 Dostateczny
    2 Dopuszczający
    1 Niedostateczny
    Dane testowe : 3
    Rezultat w terminalu :
    Dostateczny
     */

    Console.WriteLine("Podaj numer (1-7) a poznasz jaki to dzien:");
    string liczbaString = Console.ReadLine();

    Int32.TryParse(liczbaString, out var liczbaInt);

    switch(liczbaInt)
    {
        case 1:
                Console.WriteLine("To jest poniedzialek");
                break;
        case 2:
                Console.WriteLine("To jest wtorek");
            break;
        case 3:
                Console.WriteLine("To jest sroda");
            break;
        case 4:
            Console.WriteLine("To jest czwartek");
            break;
        case 5:
            Console.WriteLine("To jest piatek");
            break;
        case 6:
            Console.WriteLine("To jest sobota");
            break;
        case 7:
            Console.WriteLine("To jest niedziela");
            break;
        default:
            Console.WriteLine("podales zly znak");
            break;

    }
}

void Zadanie11()
{
    /* 
     11.Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
     Ocena Opis
     6 Celujący
     5 Bardzo dobry
     4 Dobry
     3 Dostateczny
     2 Dopuszczający
     1 Niedostateczny
     Dane testowe : 3
     Rezultat w terminalu :
     Dostateczny
    */
    Console.WriteLine("Jaka ocene dostale ?");
    string liczbaString = Console.ReadLine();

    Int32.TryParse(liczbaString, out var liczbaInt);

    switch (liczbaInt)
    {
        case 1:
            Console.WriteLine("Niedostateczny");
            break;
        case 2:
            Console.WriteLine("Dopuszczajacy");
            break;
        case 3:
            Console.WriteLine("Dostateczny");
            break;
        case 4:
            Console.WriteLine("Dobry");
            break;
        case 5:
            Console.WriteLine("Bardzo dobry");
            break;
        case 6:
            Console.WriteLine("Celujacy");
            break;
        
        default:
            Console.WriteLine("podales zly znak");
            break;

    }
}

void Zadanie13()
{
    /*
     13. Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I
    będzie prostym kalkulatorem
    Podaj pierwszą liczbę:
    …
    Podaj drugą liczbę:
    …
    Podaj numer operacji do wykonania:
    1. Dodawanie
    2. Odejmowanie
    3. Mnożenie
    4. Dzielenie
    …
    Twój wynik to:
     */

    Console.WriteLine("Podaj pierwsz liczbe:");
    string liczbaAString = Console.ReadLine();

    Int32.TryParse(liczbaAString, out var liczbaAInt);

    Console.WriteLine("Podaj druga liczbe:");
    string liczbaBString = Console.ReadLine();

    Int32.TryParse(liczbaBString, out var liczbaBInt);

    Console.WriteLine("Podaj numer operacji do wykonania:");
    Console.WriteLine("  1. Dodawanie");
    Console.WriteLine("  2. Odejmowanie");
    Console.WriteLine("  3. Mnożenie");
    Console.WriteLine("  4. Dzielenie");
    string liczbaCString = Console.ReadLine();
    Int32.TryParse(liczbaCString, out var liczbaCInt);

    int Wynik = 0;

    switch (liczbaCInt)
    {
        case 1:
            Wynik = liczbaAInt + liczbaBInt;
            Console.WriteLine("Twoj wynik to " + Wynik);
            break;
        case 2:
            Wynik = liczbaAInt - liczbaBInt;
            Console.WriteLine("Twoj wynik to " + Wynik);
            break;
        case 3:
            Wynik = liczbaAInt * liczbaBInt;
            Console.WriteLine("Twoj wynik to " + Wynik);
            break;
        case 4:
            Wynik = liczbaAInt / liczbaBInt;
            Console.WriteLine("Twoj wynik to " + Wynik);
            break;
        default:
            Console.WriteLine("Twoj wynik to " + Wynik);
            break;

    }
}

//Zadanie1();
//Zadanie2();
//Zadanie3();
//Zadanie4();
//Zadanie5();
//Zadanie6();

/*while (wyjscieZPetli!="x")
{
    Zadanie7(); 
}
*/

//Zadanie8();
//Zadanie9();
//Zadanie10();
//Zadanie11();
//Zadanie12();
//Zadanie13();






