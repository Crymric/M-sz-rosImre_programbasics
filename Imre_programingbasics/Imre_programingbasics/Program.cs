// Console.WriteLine("Hello World!");
// comment, nem számít bele a kódba, jegyzetelésre, az egész sor komment lesz
/* szintén komment, beleilleszthető a kódsorba */
/*
int age = 35; // int egész számos változó, ez egy típus, csharp típusos nyelv, int 32 biten tárol 
Console.WriteLine(age); 
age = 36;
Console.WriteLine(age);

int height; //deklaráció
height = 182; //definíció
Console.WriteLine(height);

int abc = age + 5 + height - 3; 
Console.WriteLine(abc);
Console.WriteLine(age + 5);

int a, b, c;

a = 5;
b = 7;
c = a + b;
c = 25; //c értékét 25re módosítja és nem a+b összege lesz
Console.WriteLine(c);

// Műveletek
int sum = a + b; // 12   operátor az összeadás, operandus az a
int dif = a - b; // -2
int product = a * b; // 35 
int rate = a / b; // int csak egész lehet, ezért ez 0 lesz

Console.WriteLine(rate);
//modulo a maradékot írja le
int modulo1 = 10 % 3; // 1 
int modulo2 = 12 % 4; // 0
int modulo3 = 6 % 5; // 1
int modulo4 = 100 % 8; // 4
int modulo5 = 12 % 16; // 12

int num1 = 3 + 2 * 4; // 11, C#-ban van műveleti sorrend
int num2 = (3 + 2) * 4; //20

int number = 0;

number = number + 5; // 5, number értéke legyen egyenlő a számmal
number += 5;         // 10

number -= 2;         // 8
number *= 2;         // 16
number /= 3;         // 5
number %= 3;         // 2    sorba számoljuk, sorrol sorra, előző sor értékéből indulunk

number += 1;         // 3
number++;            // 4

number -= 1;         // 3
number--;            // 2 

//----------------------

float f1 = 12.5f; // floating point number, tört számokat is tudja tárolni, 32 biten (4 byte), lebeg a tizedes pont
double d1 = 12.77f; // ez is tud tört számokat tárolni, de más mennyiségű biten tárolja, 64 biten (8 byte)

float f2 = 12.45f;
float f3 = 3 + f2;

// Casting - kasztolás - egy típust átalakítani egy másikba

int i1 = 7;
float f4 = 33.5f;

int i2 = (int) f4; //int-be floatot nem rakhatunk, ha tört, mert az int azt nem kezeli, ez egy explicit kasztolás, el fog veszni a vessző utáni rész
float f5 = i1; // implicit kasztolás, explicitbe jelölni kell, imlicitbe elhagyható a ()

//--------------------------------

string myOwnSpeciálString_1 = "valami szöveg"; //karakterlánc, lehet benne szám, de nem az elején

string s1 = f1 + "AAA" + " " + i1 + "BBB"; // a + operátor jel itt összefűzést jelent, az AAA és a BBB operandust fűzi össze

string s2 = 3 + i1 + "AAA"; // összefőzés és az összeadás ugyanazon a szinten van, ezért sorba végzi

int xxx = int.Parse("10"); // azért "10" mert string van benne, ez egy stringé való alakítás
xxx += 5;

int hex = 0x1A45F3B;
int bin = 0b10100101;

Console.WriteLine(bin);

//-------------------

bool b1 = false; // két értéket tud csak felvenni 1 vagy 0, false or true, bool vagy logikai típus
bool b2 = true;

bool b3 = i1 > f3; // eldönti, hogy nagyobb e
Console.WriteLine(b3);
bool b4 = i1 < f3;
bool b5 = i1 >= 43;
bool b6 = 22.4f <= f3;

bool b7 = 3 > 3;
bool b8 = 3 >= 3;

bool b9 = i1 == f3;    // egyenlőség vizsgálat operátor, ha igaz, hogy egyenlő akkor true, ha nem akkor false
bool b10 = i1 != f3;    // egyenlőtlenség vizsgálat

bool b11 = "aaabbb" == "aaaBBB"; // false
bool b12 = "aaabbb" == "aaabbb"; // true

//-----------------------------

bool b13 = b1 == b2; // b13-nak az lesz az értéke, hogy megegyezik e a b1 és b2

bool b14 = b1 && b2; // ÉS: Iga, ha mindkettő igaz
bool b15 = b1 || b2; // VAGY: Igaz, ha legalább az egyik az

bool b16 = !b1;      // NEGÁLÁS: b16-ba kerüljön be az ellentéte, a másik

bool b17 = b1 ^ b2; // XOR: kizáró vagy, ha az A igaz vagy a B igaz, de nem mind a kettő 
 */ 