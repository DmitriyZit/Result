namespace Result
{
  class Program
  {
    static void Main(string[] args)
    {
      
      // 1. Объявление переменных
      string[] AS; // массив строк
      int count = 0; // количество элементов в массиве
      string[] AS1;

      // 2. Ввести количество строк
      Console.Write("введите колличество строк = ");
      
      string s = Console.ReadLine()!;
      
      
      if (s == null || s == "") 
        {
            Console.WriteLine("Ошибка Пустая строка ");
                     

        }
        else
        {
            count = Int32.Parse(s);
        }
      
           

      // 3. Выделить память для массива из count строк
      AS = new string[count];
      AS1 = new string[count];

      // 4. Ввести данные массива с клавиатуры
      Console.WriteLine("Введите строку:");

      for (int i=0; i<AS.Length; i++)
      {
        Console.Write("AS[{0}] = ", i);
        AS[i] = Console.ReadLine()!;
        Console.WriteLine(AS[i].Length);
      }

      
      // 6. Вывести массив AS
      for ( int i = 0; i < AS.Length; i++ )
      {
        if  ( AS[i].Length <= 3)
        {
            Console.WriteLine();
            Console.WriteLine("строка меньше 3 :" + AS[i]);
            AS1[i] = AS[i];
        }
        else
        {
            Console.WriteLine("строка больше 3 :" + AS[i]);
        }
      }
      AS1 = AS1.Where(x => x != null).ToArray();
      Console.WriteLine();
      Console.WriteLine("Отсортированный массив:");
      
      Console.WriteLine(string.Join(",",AS1));
      
      Console.ReadKey();
    }
  }
}