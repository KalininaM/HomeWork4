Main();

void Main()
{
    bool isWorking = true;
    while(isWorking){
        Console.WriteLine("Input task");
        string task = Console.ReadLine();

        switch(task){
            case "exit": isWorking = false; break;
            case "t25": Task25(); break;
            case "t27": Task27(); break;
            case "t29": Task29(); break;
            default: break;
        }
    }
}

int ReadInt(string argument)
{
    int number;
    Console.Write($"Введите {argument}:");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number!");
    }
    return number;
}
/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
void Task25(){
    int numberA = ReadInt("число А");
    int numberB = ReadInt("число B");

    Console.WriteLine($"Число {numberA} в степени {numberB} равно {degreeNum(numberA, numberB)}");
}

int degreeNum(int number, int degree){
    int result = 1;

    for(int i = 1; i <= degree; i ++){
        result = result * number;
    }
    
    return result;
}
/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
void Task27(){
    int number = ReadInt("число");
    
    Console.WriteLine($"Сумма чисел число {number} = {sumNum(number)}");
}

int sumNum(int number){
    string result = number.ToString();
    int length = result.Length;
    int numberSum = 0;

    for ( int i = 0; i < length; i ++){
        numberSum = numberSum + (int)Char.GetNumericValue(result[i]);
    }

    return numberSum;    
}
/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
void Task29(){
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }

    Console.WriteLine($"[ {string.Join(", ",array)} ]");
}