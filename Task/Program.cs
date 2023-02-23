Console.Write("Введите количество строк, которые хотите ввести: ");
int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
string[] strs = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива");
    strs[i] = Console.ReadLine(); //Заполняем его
}
Console.Write("Вы ввели следующие массив -> [");
for (int i = 0; i < n; i++)
{
    if (i < n - 1)
        Console.Write($"{strs[i]}; ");
    else
        Console.WriteLine($"{strs[i]}]");
}
int temp = 0;
for (int i = 0; i < n; i++)
{
    string si = strs[i];
    if (si.Length > 3)
    {

    }
    else
    {
        strs[temp] = si;
        temp++;
    }
        

}
string[] newstrs = new string[temp];
for (int i = 0; i < temp; i++)
{
    newstrs[i] = strs[i];
}
Console.Write("Новый массив, в который включены элементы с количеством символов меньше или равно 3 -> [");
for (int i = 0; i < temp; i++)
{
    if (i < temp - 1)
        Console.Write($"{newstrs[i]}; ");
    else
        Console.WriteLine($"{newstrs[i]}]");

}
Console.Write("Нажмите [Enter] для выхода...");
Console.ReadLine();
