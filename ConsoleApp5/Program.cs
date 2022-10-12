//Коваленко, 22-ИСП-2/2, 6.101
int nod;
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
while (m != n)
{
    if (m > n)
    {
        m = m - n;
    }
    else
    {
        n = n - m;
    }
}
nod = n;
Console.WriteLine("НОД: " + nod);