namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 04:Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
            //ler a quantidade de horas aula, o valor por aula e o total recebido

            //professor 1:
            Console.WriteLine("Digite a quantidade de horas aula dadas pelo professor 1: ");
            int horasAula1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor por hora recebido pelo professor 1:");
            double valorAula1 = double.Parse(Console.ReadLine());
            double salario1 = horasAula1 * valorAula1;

            //professor 2:
            Console.WriteLine("Digite a quantidade de horas aula dadas pelo professor 2: ");
            int horasAula2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor por hora recebido pelo professor 2:");
            double valorAula2 = double.Parse(Console.ReadLine());
            double salario2 = horasAula2 * valorAula2;

            //verificar qual professor tem o maior salário
            if (salario1 > salario2)
            {
                Console.WriteLine("O professor 1 tem o maior salário total: R$ " + salario1);
            }
            else if (salario1 < salario2)
            {
                Console.WriteLine("O professor 2 tem o maior salário total: R$ " + salario2);
            }
            else
            {
                Console.WriteLine("Os dois professores têm o mesmo salário: R$ " + salario1);
            }
        }
    }
}