    public class FuncionarioTempoIntegral : Funcionarios, IBonus //classe FuncionarioTempoIntegral que herda da classe Funcionarios e implementa a interface IBonus
    {
        private double salarioMensal; //atributo salarioMensal
        

        public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal) : base(nome, matricula) //construtor da classe FuncionarioTempoIntegral
        {
            this.salarioMensal = salarioMensal; //atribui valores aos atributos
        }

        public override double CalcularSalario() //método CalcularSalario
        {
            return salarioMensal; //retorna o salário
        }

        public override void ExibirInformacoes()  //método ExibirInformacoes
        {
            Console.WriteLine("Nome: " + Nome); //exibe o nome
            Console.WriteLine("Matrícula: " + MatriculaDoFuncionario); //exibe a matrícula
            Console.WriteLine("Salário Mensal: " + salarioMensal); //exibe o salário mensal
        }

         public double CalcularBonus() //método CalcularBonus
    {
        return salarioMensal * 0.10; //retorna o bônus
    }
    }
