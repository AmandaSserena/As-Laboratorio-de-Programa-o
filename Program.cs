Empresa empresa = new Empresa(); //cria uma nova empresa
while (true) //loop infinito
{
    Console.WriteLine("Escolha uma opção:"); //menu de opções
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
    int opcao = Convert.ToInt32(Console.ReadLine()); //lê a opção escolhida

    switch (opcao) //switch case para cada opção
    {
        case 1: 
            Console.WriteLine("Digite um nome de um funcionário de tempo integral:"); //solicita o nome do funcionário
            string nomeTI = Console.ReadLine()!; //lê o nome do funcionário
            Console.WriteLine("Digite a matrícula do funcionário:"); //solicita a matrícula do funcionário
            int matriculaTI = Convert.ToInt32(Console.ReadLine()); //lê a matrícula do funcionário
            Console.WriteLine("Digite o salário mensal do funcionário:"); //solicita o salário do funcionário
            double salarioTI = Convert.ToDouble(Console.ReadLine()); //lê o salário do funcionário


            FuncionarioTempoIntegral funcionarioTI = new FuncionarioTempoIntegral(nomeTI, matriculaTI, salarioTI); //funcionarioTI vai receber todos os parâmetros
            empresa.AdicionarFuncionario(funcionarioTI);  //adiciona funcionário
            Console.WriteLine("Funcionário de tempo integral adicionado com sucesso!"); //mensagem de sucesso
            break; //sai do switch case
        
        case 2:
            Console.WriteLine("Digite o nome do funcionáiro de meio período:"); //solicita o nome do funcionário
            string nomeMP = Console.ReadLine()!; //lê o nome do funcionário
            Console.WriteLine("Digite o número de matrícula:"); //solicita a matrícula do funcionário
            int matriculaMP = Convert.ToInt32(Console.ReadLine()); //lê a matrícula do funcionário
            Console.WriteLine("Digite o salário por hora do funcionário:"); //solicita o salário por hora do funcionário
            double salarioPorHoraMP = Convert.ToDouble(Console.ReadLine()); //lê o salário por hora do funcionário
            Console.WriteLine("Digite o número de horas trabalhadas do funcionário de meio período:"); //solicita o número de horas trabalhadas
            int horasTrabalhadasMP = Convert.ToInt32(Console.ReadLine());  //lê o número de horas trabalhadas

            FuncionarioMeioPeriodo funcionarioMP = new FuncionarioMeioPeriodo(nomeMP, matriculaMP, salarioPorHoraMP,horasTrabalhadasMP); //funcionarioMP vai receber todos os parâmetros
            empresa.AdicionarFuncionario(funcionarioMP); //adiciona funcionário
            Console.WriteLine("Funcionário de meio periodo adicionado com sucesso!"); //mensagem de sucesso
            break; //sai do switch case

        case 3:
            Console.WriteLine("Digite a matrícula do funcionário que deseja remover:"); //solicita a matrícula do funcionário
            int matriculaRemover = Convert.ToInt32(Console.ReadLine()); //lê a matrícula do funcionário
            empresa.RemoverFuncionario(matriculaRemover); //remove funcionário
            break; //sai do switch case


        case 4:
            empresa.ExibirFuncionarios(); //exibe informações dos funcionários
            break; //sai do switch case

        case 5:
            Console.WriteLine("Digite a matrícula do funcionário que deseja adicionar um projeto:"); //solicita a matrícula do funcionário
            int matriculaProjeto = Convert.ToInt32(Console.ReadLine()); //lê a matrícula do funcionário
            Console.WriteLine("Digite o nome do projeto:"); //solicita o nome do projeto
            string nomeProjeto = Console.ReadLine()!; //lê o nome do projeto
            empresa.AdicionarProjeto(matriculaProjeto, nomeProjeto); //adiciona projeto ao funcionário
            break; //sai do switch case

        case 6: 
            Environment.Exit(0); //sai do programa
            break; //sai do switch case
    }
}