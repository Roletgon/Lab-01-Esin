Console.Write("Введите строку: ");
string input = Console.ReadLine();

char[] arr = input.ToCharArray();
Array.Reverse(arr);

Console.WriteLine("Результат: " + new string(arr));
Console.Read();