/*
int ResultNumbers (int m, int n)
{
    int first = m;
    int last = n;
    if(m > n)
{
        first = n;
        last = m;
}
            return (last+ first)*(last - first + 1)/2; 
}
        
        
        Console.Clear();
Console.Write("Введите число 1-ое: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2-ое: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ResultNumbers(m, n));

*/
/*
    int Akkermanfunc(int m, int n)
{
    if(m == 0)
{
    return n + 1;
}
    if(m > 0 && n == 0)
{
        return Akkermanfunc(m - 1, 1);
}
        return Akkermanfunc(m - 1, Akkermanfunc(m, n - 1));
}
        
        

           Console.Clear();
Console.Write("Введите число 1-ое: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2-ое: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkermanfunc(m, n));
*/