    public class FuncionarioTempoIntegral : Funcionarios, IBonus
    {
        private double salarioMensal;
        

        public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal) : base(nome, matricula)
        {
            this.salarioMensal = salarioMensal;
        }

        public override double CalcularSalario()
        {
            return salarioMensal;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Matrícula: " + MatriculaDoFuncionario);
            Console.WriteLine("Salário Mensal: " + salarioMensal);
        }

         public double CalcularBonus()
    {
        return salarioMensal * 0.10;
    }
    }
