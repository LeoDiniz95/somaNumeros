
int initial = 1;
int newValue = 0;
int total = 0;


do
{
    try
    {
        do
        {
            Console.WriteLine("Digite um número maior que 1:");
            newValue = int.Parse(Console.ReadLine());

            if (newValue > 0)
                break;
            else
                Console.WriteLine("Por favor, digite valor maior que zero!");

        } while (true);



        do
        {
            total += initial;

            initial++;
        } while (initial <= newValue);

        Console.WriteLine("Soma dos valores: " + total);
        Console.ReadLine();

        string anotherSum = string.Empty;
        bool closeSession = false;
        bool willSum = true;

        while (willSum)
        {

            Console.WriteLine("Deseja realizar outra Soma? S/N");
            anotherSum = Console.ReadLine();

            switch (anotherSum.ToUpper())
            {
                case "S":
                    willSum = false;
                    break;

                case "N":
                    willSum = false;
                    closeSession = true;
                    break;

                default:
                    Console.WriteLine("Valor inválido, digite S(sim) ou N(não)");
                    break;

            }
        }

        if (closeSession)
            break;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro inesperado...");
        Console.WriteLine("Tente fazer sua operação novamente.");
        Console.ReadLine();
    }

} while (true);