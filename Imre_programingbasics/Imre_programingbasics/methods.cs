/*
double x = Math.Pow(3, 5);

float y = Math.Abs(-4);

float z = Abs(4);
*/
/*
WriteCounting(10);
WriteCounting(5);
WriteCounting(16);
*/

WriteFirstNPrime(100);

float Abs(float input) //metódus, abszolút értékké alakítás
{
    if (input < 0) //ha nagyobb, mint 0
        input = input * -1; //minusszá szorzom

    return input;
}


void WriteCounting(int n) //void, ha nincs kimenete tipusa a metodusnak
{
    for (int i = 1; i <= n; i++) //dupla tab hotkey
    {
        Console.WriteLine(i);
    }
}

bool IsPrime(int number)  //egy számról megmondja, hogy prím e -  IsPrime metódust hoztunk létre, ami bármikor behívható
{
    for (int i = 2; i <= number / 2; i++)
    { 
    if (number % i == 0)
            return false;
    }

    return true;
}


void WriteFirstNPrime(int n)  //prím számokat irítunk ki, WriteFirstNPrime(100); - hogy mennyi darabot

{
    int found = 0;

    for (int i = 2; i <= n; i++)
    {
        if (IsPrime(i))
        {
            found++;
            Console.WriteLine(found + " " + i);

        }
    }
}