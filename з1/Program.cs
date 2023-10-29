Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine());

void count (int number)
{
    if(number == 0)
    return;
    Console.Write(number);
    count(number -1);
}
count(number);
