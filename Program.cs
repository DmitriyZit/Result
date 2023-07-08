namespace ConsoleApp8
{
  class Program
  {
    static void Main(string[] args)
    {
      // Сортировка массива строк методом вставки
      // 1. Объявление переменных
      string[] AS; // массив строк
      int count; // количество элементов в массиве
      string s; // дополнительная переменная-строка

      // 2. Ввести количество строк
      Console.Write("колличество строк = ");
      count = Int32.Parse(Console.ReadLine());

      // 3. Выделить память для массива из count строк
      AS = new string[count];

      // 4. Ввести данные массива с клавиатуры
      Console.WriteLine("Введите строку:");

      for (int i=0; i<AS.Length; i++)
      {
        Console.Write("AS[{0}] = ", i);
        AS[i] = Console.ReadLine();
      }

      // 5. Сортировка методом вставки
      for (int i = 0; i < AS.Length - 1; i++)
        for (int j = i; j >= 0; j--)
          if (String.Compare(AS[j], AS[j + 1]) > 0) // функция Compare()
          {
            // поменять значения местами
            s = AS[j];
            AS[j] = AS[j + 1];
            AS[j + 1] = s;
          }

      // 6. Вывести массив AS
      Console.WriteLine();
      Console.WriteLine("Отсортированный массив:");
      for (int i = 0; i < AS.Length; i++)
        Console.WriteLine("AS[{0}] = {1}", i, AS[i]);

      Console.ReadKey();
    }
  }
}