// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна
// 3 символам. Первоначальный массив можно ввести с клавиатуры, либо
// задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.


string [] arr_1 = {"Hello", "2", "world", ":-)", "ab", "312"};
int count = 0;

for (int i = 0; i < arr_1.Length; i++)
{
    if (arr_1[i].Length <= 3)
    {
      count += 1;
    }
}

string[] array_result = new string[count];
int k = 0;

for (int i = 0; i < array_result.Length; i++)
{
   for (int j = k; j < arr_1.Length; j++)
   {
      if (arr_1[j].Length <= 3)
      {
         array_result[i] = arr_1[j];
         k = j + 1;
         break;
      }
   }
   Console.WriteLine(array_result[i]);
}