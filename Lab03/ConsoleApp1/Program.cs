//z1

using System.Collections.Generic;

int a = 10;
do
{
    Console.WriteLine(a);
    a--;

} while (a >=0);


//z2


string s = " ";
Console.WriteLine("Podaj hasło(koniec); ");
do
{
    
    s = Console.ReadLine();

} while (s != "koniec");

//z3
int i=1;
while(i<=100)
{
    if (i%2==0)
    {
        Console.WriteLine(i);
    }
    i++;
}

//z4
for(int j = 1; j<=15; j++)
{
    Console.WriteLine(j * j);
}

//z5

List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };
foreach(int element in numbers)
{
    if(element%7==0)
    {
        Console.WriteLine(element);
    }

}

//z6
foreach (int element in numbers)
{
    if (element % 7 == 0)
    {
        Console.WriteLine(element);
        break;
    }

}

//z7
double[] tab = new double[20];
for(int k=0;k<tab.Length;k++)
{
    tab[k] = Math.Sqrt(k);
}


//z8
int[,] wym = new int[3, 4];
int liczba = 1;

for (int m = 0; m < 3; m++)
{
    for (int n = 0; m < 4; n++)
    {
        wym[m, n] = liczba;
       liczba++;
    }
}

//z10
void duze(string a)
{
    a = a.ToUpper();
    Console.WriteLine(a);



}
duze("duze");
//z11
void dolarki(int x, int y)
{
    char[,] doltab = new char[x, y];
    for(int dd = 0;dd<x; dd++)
    {
        for( int dw = 0; dw < y; dw++)
        {
            doltab[dd, dw] = '$';
        }
    }
    for (int dd = 0; dd < x; dd++)
    {
        for (int dw = 0; dw < y; dw++)
        {
            Console.Write(doltab[dd, dw]+ " ");
        }
        Console.WriteLine();
        
    }
}
dolarki(10, 10);

//z12

 static string Sprawdzparzysta(int h)
{
    if (h%2 ==0)
    {
        return "even";
    }
    else
    {
        return "odd";

    }

}
Sprawdzparzysta(2);

//z13
static void prostokat(int szer ,int wys)
{
    for (int i = 0; i < szer; i++)
    {
        for (int j = 0; j < wys; j++) 
        {
            if (i == 0 || i == szer -1 || j==0|| j == wys - 1)
            {
                Console.Write("$ ");
            }
            else
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine();

    }
}
prostokat(10, 10);

