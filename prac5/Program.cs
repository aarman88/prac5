using System;

class Program
{
    static void Main()
    {
        try
        {
            CallMethodWithException();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }

    static void CallMethodWithException()
    {
        Console.WriteLine("Метод CallMethodWithException начал работу.");
        GenerateException();
        Console.WriteLine("Метод CallMethodWithException завершил работу.");
    }

    static void GenerateException()
    {
        Console.WriteLine("Метод GenerateException начал работу.");
        // Генерируем исключение
        throw new Exception("Это тестовое исключение.");
        Console.WriteLine("Метод GenerateException завершил работу.");
    }
}
