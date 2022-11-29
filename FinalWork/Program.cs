Console.Clear();

/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равно 3 символа 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не реккомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

void FinishWork()

{
string [] numbers=new string[5];
string [] newnumbers= new string [numbers.Length];
Console.WriteLine("Введите 5 значений");

for(int i=0;i<numbers.Length;i++)
{
    String word=Console.ReadLine();
    numbers [i]=word;
}

Console.WriteLine();
Console.WriteLine("Пeрвоначальный массив: ");
PrintArray(numbers);
FillArray(numbers, newnumbers);
Console.WriteLine();
Console.WriteLine("Обработанный массив: ");
PrintArray(newnumbers);

void FillArray (String[] numbers, String[] newnumbers)                          //Метод заполнения массива
{
int j = 0;
for (int i = 0; i < newnumbers.Length; i++)
{
    if(numbers[i].Length <= 3) {
        newnumbers[j++] = numbers[i];
    }
}
}

void PrintArray(String[] numbers)                                               //Метод печати массива
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} "); 
    }
    Console.WriteLine();
}

}

FinishWork();
