/* Console.WriteLine("Hello Wrold!");

// Elágazások

int ammo = 10;
bool isInAir = false;

if (ammo > 0 && !isInAir)
{
    Console.WriteLine("BUMM");
    ammo--; 
}

bool isGrounded = !isInAir;
bool haveAmmo = ammo > 0;
bool canShoot = haveAmmo && isGrounded;
if (canShoot)
{
    Console.WriteLine("BUMM");
}
else
{
    Console.WriteLine("KLICK");
}

//------------

Console.WriteLine("Írj be egy egész számot!");
string line = Console.ReadLine();
int number = int.Parse(line);

Console.WriteLine("A szám duplája:");
Console.WriteLine(number * 2);
*/



/*
Console.WriteLine("Írj be egy egész számot!");
// Páros vagy páratlan
string line = Console.ReadLine();
int number = int.Parse(line);

bool isEven = (number % 2) == 0;
if (isEven)
{
    Console.WriteLine("Páros");
}
else
{
    Console.WriteLine("Páratlan");
}
*/

/*
//--------------------------
//Pozitív, negatív

Console.WriteLine("Írj be egész számot!");
string line = Console.ReadLine();
int number = int.Parse(line);

if (number > 0)
{
    Console.WriteLine("Pozitív");
}
else if (number < 0) //különben ha
{
    Console.WriteLine("Negatív");
}
else
{
    Console.WriteLine("Nulla");
}



//-------------
// Kerek, nem kerek

Console.WriteLine("Írj be egész számot!");
string line = Console.ReadLine();
int number = int.Parse(line);

string text = number % 10 == 0 ? "Kerek" : "Nem kerek"; //feltételes értékadás operátor, ? elsődleges ha ez nem jó akkor a : utáni értéket adja
Console.WriteLine();

*/

//---------------- CIKLUSOK -----------------------
/*
int i = 1;

while (i <= 100) 
{
    Console.WriteLine(i);
    i++;
}

for (int j = 1; j <= 100; j++)
{
    Console.WriteLine(j);
}
*/
/*
//--------------------
// Első 10 szám, ami osztható 3-al

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i * 3);
}
*/

//----------------------
//Első n olyan természetes szám, ami osztható 5-el, de nem osztható 7-el
/*
Console.WriteLine("Hány számot írjak ki?");
string line = Console.ReadLine();
int n = int.Parse(line);

int x = 5;
int count = 0;

for (int i = 1; count < n; i++)
{
    int numberToWrite = i * x;

    bool devisibleWith7 = numberToWrite % 7 == 0;

    if (!devisibleWith7)
    {
     Console.WriteLine(numberToWrite);
        count++;
    }
}

*/

//----------------
//Szorzótábla
/*
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        int result = i * j;
        Console.WriteLine(j + " * " + i + " = " + result);
    }
}
*/

//-------------------
// Metódusok

double f1 = 12.5f;
double f2 = 3;

double power = Math.Pow(f1,f2);
double power2 = Math.Pow(45, 11.5);

double f3 = Math.Abs(f1);

double pi = Math.PI;