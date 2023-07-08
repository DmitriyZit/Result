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
      string[] AS1;
      // 2. Ввести количество строк
      Console.Write("колличество строк = ");
      
      count = Int32.Parse(Console.ReadLine());
      if (count == 0)
      {
        Console.WriteLine("Введите число строк:");
        count = 1;
      }
      

      // 3. Выделить память для массива из count строк
      AS = new string[count];
      AS1 = new string[count];

      // 4. Ввести данные массива с клавиатуры
      Console.WriteLine("Введите строку:");

      for (int i=0; i<AS.Length; i++)
      {
        Console.Write("AS[{0}] = ", i);
        AS[i] = Console.ReadLine();
        Console.WriteLine(AS[i].Length);
      }

      
      // 6. Вывести массив AS
      for ( int i = 0; i < AS.Length; i++ )
      {
        if  ( AS[i].Length <= 3)
        {
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив:");
            Console.WriteLine("меньше 3 :" + AS[i]);
            AS1[i] = AS[i];
        }
      }

      Console.WriteLine();
      Console.WriteLine("Отсортированный массив:");
      for (int i = 0; i < AS1.Length; i++)
      {
        //Console.WriteLine("AS1[{0}] = {1}", i, AS1[i]);
        
      }
      Console.WriteLine(string.Join(",",AS1));
      Console.ReadKey();
    }
  }
}