public class FuncionarioMeioPeriodo : Funcionarios, IBonus //classe FuncionarioMeioPeriodo que herda da classe Funcionarios e implementa a interface IBonus
{
    private double salarioPorHora; //atributo salarioPorHora
    private double horasTrabalhadas; //atributo horasTrabalhadas


    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora, double horasTrabalhadas) : base(nome, matricula) //construtor da classe FuncionarioMeioPeriodo
    {
        this.salarioPorHora = salarioPorHora; //atribui valores aos atributos
        this.horasTrabalhadas = horasTrabalhadas; //atribui valores aos atributos
    }

    public override double CalcularSalario() //método CalcularSalario
    {
        return salarioPorHora * horasTrabalhadas; //retorna o salário
    }

    public override void ExibirInformacoes() //método ExibirInformacoes
    {
        Console.WriteLine("Nome: " + Nome); //exibe o nome
        Console.WriteLine("Matrícula: " + MatriculaDoFuncionario); //exibe a matrícula
        Console.WriteLine("Salário por hora: " + salarioPorHora);  //exibe o salário por hora
    }

     public double CalcularBonus() //método CalcularBonus
    {
        return salarioPorHora * 0.5; //retorna o bônus
    }
}
