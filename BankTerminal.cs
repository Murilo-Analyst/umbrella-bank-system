namespace Aula25
{
    public class BankTerminal
    {
        // Instancia da classe BankOperation
        BankOperation bank = new BankOperation();
       
       public void start()
        {
            var inExecution = true;

            while (inExecution)
            {
                DisplayMenu();
                string option = Console.ReadLine();

                if(option == "1")
                {
                    bank.CheckBalance();
                }
                else if(option =="2")
                {
                    bank.Deposit();
                }
                else if(option == "3")
                {
                    bank.WithDraw();
                }
                else if(option == "4")
                {
                    bank.SimulateLoan();
                }
                else if(option =="5")
                {
                    Console.WriteLine("Obrigado! volte sempre.");
                    inExecution = false;
                }
                else
                {
                    Console.WriteLine("Operação inválida,Tente novamente");
                }
            }
        }
       
       
        public void DisplayMenu()
        {
            Console.WriteLine("Bem-vindo ao Umbrella Bank!");
            Console.WriteLine($"Seu saldo inicial é R$ {bank.GetBalance():F2}");
            Console.WriteLine("1 - Checar saldo");
            Console.WriteLine("2 - Realizar Depósito");
            Console.WriteLine("3 - Realizar Saque");
            Console.WriteLine("4 - Simular emprestimo");
            Console.WriteLine("5 - Sair");

        }
    }
}