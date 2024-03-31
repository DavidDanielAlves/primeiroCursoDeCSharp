
string mensagemdeboasvindas = "\nbem vindo ao screen sound";
// List<string> listaDeBandas = new List<string>() { "AC/DC", "Guns and Roses", "Metalica"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
void ExibirLogo()
{
    Console.WriteLine(@"
 ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░░██████╗
 ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗██╔════╝
 ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║╚█████╗░
 ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║░╚═══██╗
 ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝██████╔╝
 ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░╚═════╝░");
    Console.WriteLine(mensagemdeboasvindas);
}

void exibiropcoesdomenu()
{
    ExibirLogo();
    Console.WriteLine("\ndigite 1 para registrar uma banda");
    Console.WriteLine("digite 2 para mostrar todas as bandas");
    Console.WriteLine("digite 3 para avaliar uma banda");
    Console.WriteLine("digite 4 para exibir a média de uma banda");
    Console.WriteLine("digite -1 para sair");

    Console.Write("\nescolha uma opção: ");
    string opcaoescolhida = Console.ReadLine()!;
    int opcaoescolhidainteiro = int.Parse(opcaoescolhida);

    switch (opcaoescolhidainteiro)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            mostrarMediaDaBanda();
            break;
        case -1:
            Console.WriteLine("até mais...");
            break;
        default:
            Console.WriteLine("opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulo("Registro de bandas");
    Console.Write("Digite o nome da banda a ser cadastrada: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi cadastrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    exibiropcoesdomenu();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTitulo("Bandas registradas");
    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.Write("Digite qualquer tecla para sair ");
    Console.ReadKey();
    Console.Clear();
    exibiropcoesdomenu();
}

void ExibirTitulo(string titulo)
{
    int numeroDeCaracteres = titulo.Length;
    string asteriscos = string.Empty.PadLeft(numeroDeCaracteres, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTitulo("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBandaDigitada = Console.ReadLine()!.ToLower();
    if (bandasRegistradas.ContainsKey(nomeDaBandaDigitada))
    {
        Console.Write($"Qual nota a banda merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBandaDigitada].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBandaDigitada}");
        Thread.Sleep(4000);
        Console.Clear();
        exibiropcoesdomenu();
    }else
    {
        Console.WriteLine($"A banda {nomeDaBandaDigitada} não foi encontrada!");
        Console.Write("Digite qualquer tecla para voltar ao menu ");
        Console.ReadKey();
        Console.Clear();
        exibiropcoesdomenu();
    }
}

void mostrarMediaDaBanda()
{
    Console.Clear();
    ExibirTitulo("Média das Bandas");
    Console.Write("Qual a banda você quer ver a media: ");
    string nomeDaBandaDigitada = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBandaDigitada))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBandaDigitada];
        Console.WriteLine($"A média da banda {nomeDaBandaDigitada} é {notasDaBanda.Average()}");
        Console.Write("Digite qualquer coisa para voltar ao menu principal ");
        Console.ReadKey();
        Console.Clear();
        exibiropcoesdomenu();
    } else
    {
        Console.WriteLine($"A banda {nomeDaBandaDigitada} não foi encontrada!\n");
        Console.Write("Digite qualquer tecla para voltar ao menu \n");
        Console.ReadKey();
        Console.Clear();
        exibiropcoesdomenu();
    }
}

exibiropcoesdomenu();
