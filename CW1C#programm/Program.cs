string[] array = new string[3]; // создаем новый массив на три элемента
System.Console.WriteLine("Введите первую строку-");
array[0] = Console.ReadLine();
System.Console.WriteLine("Введите вторую строку-");
array[1] = Console.ReadLine();
System.Console.WriteLine("Введите третью строку-");
array[2] = Console.ReadLine();
System.Console.WriteLine(string.Join(", ", array)); // выводим на печать поллучивщийся массив, для наглядности
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