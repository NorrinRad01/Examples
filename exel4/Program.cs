/*
// method 1
void Method1()
{
    Console.WriteLine("autor Agen");
}
//Method1();

// method 2
void Method2(string msg)
{
Console.WriteLine(msg);
}
//Method2("text message");

void Method21(string msg, int count)
{
   int i = 0;
   while (i < count)
   {
    Console.WriteLine(msg);
    i++;
   }
}
//Method21("text", 4);

// methode 3

int Method3()
{
    return DateTime.Now.Year;
}
//int Year= Method3();
//Console.WriteLine(Year);

// methode 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
//string res = Method4(5, "argen ");
//Console.WriteLine(res);



/*
// Таблица умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
       Console.WriteLine($"{i} x {j} = {i * j}"); 
    }
    Console.WriteLine();
}
*/

/*
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "с" заменить большими "С",
// а большие "С" заменить маленькими "с"

string text = "О тебе знает весь Бишкек, вся такая в суете, "
            + " Вырубай свет и нахер всех, ты такая на зло всем";

string Replace(string text, char oldValue, char newValue)
{
  string result = String.Empty;

  int length = text.Length;
  for (int i = 0; i < length; i++)
  {
    if(text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
  }

  return result;
}
string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
*/

/*
// упорядочить массив с минимального до максимального
int[] arr ={1, 2, 4, 5, 7, 8, 9, 2, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
     for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

       for (int j = i + 1; j < array.Length; j++)
       {
        if(array[j] < array[minPosition]) minPosition = j;
       }


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

*/

// упорядочить массив с максимального до минимального 
int[] arr ={1, 2, 4, 5, 7, 8, 9, 2, 1, 1, 11, 33, 54};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
     for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;

       for (int j = i; j < array.Length; j++)
       {
        if(array[maxPosition] < array[j]) maxPosition = j;
       }


        int temporary = array[maxPosition];
        array[maxPosition] = array[i];
        array[i] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
