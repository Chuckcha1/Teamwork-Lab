Main();
void Main()
{
    Console.WriteLine("Введите любую строку. Программа автоматически сделает их капсом:");

    string input = Console.ReadLine();
    if (input == "")
    {
        System.Console.WriteLine("Вы ничего не ввели!\n");
        Main();
    }
        
    System.Console.WriteLine(input.ToUpper());
}
