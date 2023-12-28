class Program
{
    static void Main(string[] args)
    {
        int res1 = 0;
        int res2 = 0;
        int res_fin = 0;
        char oper = 'n';
        if (args.Length == 0)
        {
            Console.WriteLine("Аргументы не введены, прекращение работы приложения");
            return;
        }
        else if (args.Count() <= 2) //(args.Length == 1 || args.Length == 2)
        {
            Console.WriteLine($"Введено {args.Length} агрумента,необходимо ввести 3, прекращение работы приложения");
            return;
        }
        else if (args.Length == 3 && !int.TryParse(args[0], out res1))
        {
            Console.WriteLine("1-ый аргумент не является цифрой, прекращение работы приложения");
            return;
        }
        else if (args.Length == 3 && !int.TryParse(args[2], out res2))
        {
            Console.WriteLine("3-ий аргумент не является цифрой, прекращение работы приложения");
            return;
        }
        //else if (args.Length == 3 && !char.TryParse(args[1].ToCharArray()[0].ToString(), out  oper))
        //{
        //    Console.WriteLine("2-ой аргумент не является математическим символом, прекращение работы приложения\"");
        //    return;
        //}
        else if (args.Length > 3)
        {
            Console.WriteLine("Введено больше 3-ёх аргументов, прекращение работы приложения");
            return;
        }

        switch (oper)
        {
            case '-':
                res_fin = res1 - res2;
                Console.WriteLine($"Резутат вычитания равен {res_fin}");
                break;
            case '+':
                res_fin = res2 + res1;
                Console.WriteLine($"Результат сложения равен {res_fin}");
                break;
            case '*':
                res_fin = res1 * res2;
                Console.WriteLine($"Результат умножения равен {res_fin}");
                break;
            case '/':
                res_fin = res1 / res2;
                Console.WriteLine($"Результат деления равен {res_fin}");
                break;
            default:
                Console.WriteLine("2-ой аргумент не является математическим символом, прекращение работы приложения");
                break;
        }

    }
}