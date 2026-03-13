namespace Aula25
{
    public class BankOperation
    {       
         public decimal GetBalance()
        {
            return balance;      
        }
        
        Random random = new Random();
        decimal balance;

        public BankOperation()
      {
        int initialBalance = random.Next(10, 50000);
        balance = initialBalance;
      }

        public void CheckBalance()
        {
            Console.WriteLine($"Seu saldo é R$ {balance}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }

        public void Deposit()
        {
            Console.WriteLine("Informe o valor a ser depositado: R$");

            if(decimal.TryParse(Console.ReadLine(), out decimal amount)&& amount > 0)
            {
                balance = balance + amount;
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }

        public void WithDraw()
        {
            Console.WriteLine("Informe o valor a ser retirado:R$");

            if(decimal.TryParse(Console.ReadLine(), out decimal amount)&& amount > 0)
            {
                if(amount <= balance)
                {
                    balance = balance - amount;
                    Console.WriteLine($"Valor de R${amount} retirado com sucesso");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }

        public void SimulateLoan()
        {
            Console.WriteLine("Informe o valor do empréstimo: R$");

            if (decimal.TryParse(Console.ReadLine(), out decimal value) && value > 0)
            {
                Console.WriteLine("Informe a quantidade de parcelas:");

            if (int.TryParse(Console.ReadLine(), out int installments) && installments > 0)
            {      
                Console.WriteLine("Informe a taxa de juros (%):");

            if (decimal.TryParse(Console.ReadLine(), out decimal rate) && rate > 0)
            {
                decimal interest = value * (rate / 100);
                decimal total = value + interest;
                decimal installmentValue = total / installments;

                Console.WriteLine($"Valor solicitado: R$ {value}");
                Console.WriteLine($"Juros total: R$ {interest}");
                Console.WriteLine($"Valor total: R$ {total}");
                Console.WriteLine($"Parcelas: {installments}");
                Console.WriteLine($"Valor da parcela: R$ {installmentValue:F2}");
            }
        }
    }
}
    }

}