System.Console.WriteLine("Введите количество элдементов массива-");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size]; // создаем массив с которым будем работать
for (int k = 0; k < size; k++)   // заполняем массив с клавиатуры
{
    System.Console.WriteLine( $"Введите {k+1}-й элемент массива");
    array[k] = Console.ReadLine();
}

int i = 0; // счетчик для перебора массива
int j = 0; // счетчик кол-ва элементов для новго массива

while (i < array.Length)
{
    if (array[i].Length <= 3) j++;
    i++;
}

string[] resultArray = new string[j]; // создаём новый массив нужного размера
i = 0;
j = 0;

while (i < array.Length)  // коприруем подходящие строки в новый массив
{
    if (array[i].Length <= 3)
    {
        resultArray[j] = array[i];
        j++;
    }
    i++;
}
if (j>0) System.Console.WriteLine($"Итоговый массив - [{string.Join(", ", resultArray)}]"); 
else System.Console.WriteLine("Итоговый массив - [ ]");