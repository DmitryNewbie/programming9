Console.WriteLine("Введите число M");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = int.Parse(Console.ReadLine());

void SumNumber (int numberM, int numberN, int sum)
{
    if(numberM > numberN)
    {
        Console.WriteLine(sum);
        return;
    }
    sum += numberM++;
    
    SumNumber( numberM, numberN, sum);
}
SumNumber(numberM, numberN, 0 );