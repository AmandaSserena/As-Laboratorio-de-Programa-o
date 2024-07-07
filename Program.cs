Empresa empresa = new Empresa();
while (true)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Adicionar um funcionário de tempo integral");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("2. Adicionar um funcionário de meio período");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("3. Remover um funcionário");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("4. Exibir informações de todos os funcionários");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("5. Adicionar projeto a um funcionário");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("6. Sair do programa");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1: 
            Console.WriteLine("Digite um nome de um funcionário de tempo integral:");
            string nomeTI = Console.ReadLine()!;
            Console.WriteLine("Digite a matrícula do funcionário:");
            int matriculaTI = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o salário mensal do funcionário:");
            double salarioTI = Convert.ToDouble(Console.ReadLine());


            FuncionarioTempoIntegral funcionarioTI = new FuncionarioTempoIntegral(nomeTI, matriculaTI, salarioTI); //funcionarioTI vai receber todos os parâmetros
            empresa.AdicionarFuncionario(funcionarioTI); 
            Console.WriteLine("Funcionário de tempo integral adicionado com sucesso!");
            break;
        
        case 2:
            Console.WriteLine("Digite o nome do funcionáiro de meio período:");
            string nomeMP = Console.ReadLine()!;
            Console.WriteLine("Digite o número de matrícula:");
            int matriculaMP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o salário por hora do funcionário:");
            double salarioPorHoraMP = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas do funcionário de meio período:");
            int horasTrabalhadasMP = Convert.ToInt32(Console.ReadLine()); 

            FuncionarioMeioPeriodo funcionarioMP = new FuncionarioMeioPeriodo(nomeMP, matriculaMP, salarioPorHoraMP,horasTrabalhadasMP);
            empresa.AdicionarFuncionario(funcionarioMP);
            Console.WriteLine("Funcionário de meio periodo adicionado com sucesso!");
            break;

        case 3:
            Console.WriteLine("Digite a matrícula do funcionário que deseja remover:");
            int matriculaRemover = Convert.ToInt32(Console.ReadLine());
            empresa.RemoverFuncionario(matriculaRemover);
            break;


        case 4:
            empresa.ExibirFuncionarios();
            break;

        case 5:
            Console.WriteLine("Digite a matrícula do funcionário que deseja adicionar um projeto:");
            int matriculaProjeto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome do projeto:");
            string nomeProjeto = Console.ReadLine()!;
            empresa.AdicionarProjeto(matriculaProjeto, nomeProjeto);
            break;

        case 6: 
            Environment.Exit(0);
            break;
    }
}