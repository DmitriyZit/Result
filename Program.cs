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
      if (count == 0)
      {
        Console.WriteLine("Введите число строк:");
      }
      

      // 3. Выделить память для массива из count строк
      AS = new string[count];

      // 4. Ввести данные массива с клавиатуры
      Console.WriteLine("Введите строку:");

      for (int i=0; i<AS.Length; i++)
      {
        Console.Write("AS[{0}] = ", i);
        AS[i] = Console.ReadLine();
        Console.WriteLine(AS[i].Length);
      }

      /* 5. Сортировка методом вставки
      for (int i = 0; i < AS.Length - 1; i++)
        for (int j = i; j >= 0; j--)
          if (String.Compare(AS[j], AS[j + 1]) > 0) // функция Compare()
          {
            // поменять значения местами
            s = AS[j];
            AS[j] = AS[j + 1];
            AS[j + 1] = s;
          }
        */
      // 6. Вывести массив AS
      for ( int i = 0; i < AS.Length - 1; i++ )
      {
        if  (int j=0; AS[j].Length <= 3; j++)
        {
            Console.WriteLine();
            Console.WriteLine("все что меньше 3 :" , AS[j]);
        }
      }

      Console.WriteLine();
      Console.WriteLine("Отсортированный массив:");
      for (int i = 0; i < AS.Length; i++)
      {
        Console.WriteLine("AS[{0}] = {1}", i, AS[i]);
      }
      Console.ReadKey();
    }
  }
}