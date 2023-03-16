using System;

Console.WriteLine("_______________________________________");
Console.WriteLine("Andrea Gabriela Iboy Casados - 1076623");
Console.WriteLine("_______________________________________");

int n = 0;

try
{
    Console.WriteLine("Debes ingresar un número mayor a 0: ");
    n = Convert.ToInt32(Console.ReadLine());

    if (n <= 0)
    {
        throw new Exception("El numero que se debe ingresar es mayor a 0: ");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Invalido, intentalo de nuevo: " + ex.Message);
    return;
}

int a = 0, b = 1, c = 0;
int i = 0;

while (i < n)
{
    Console.WriteLine("{0}: {1}", i + 1, a);
    c = a + b;
    a = b;
    b = c;
    i++;
}
