Console.Clear();
string[] escolha = {"pedra", "papel", "tesoura" };

int pontosPC = 0;
int pontosJG = 0;

    while (true)
    {
        Console.WriteLine("Escolha Pedra, Papel ou Tesoura.");
        Console.WriteLine("Ou Sair para terminar.");
        string jogador = Console.ReadLine()!.ToLower();
        Console.Clear();


        if (jogador == "sair")
        {
            Console.Clear();
            break;
        }

         if (jogador != "pedra" && jogador != "papel" && jogador != "tesoura")
            {
                Console.WriteLine("Opção inválida! Por favor, escolha entre Pedra, Papel ou Tesoura.");
                Thread.Sleep(3000);
                Console.Clear();
                continue; // Reinicia o loop para que o usuário possa fazer outra escolha válida
            }

        Random rnd = new Random();
        int escolhaComputador = rnd.Next(0, 3);
        string escolhaPC = escolha[escolhaComputador];

        Console.WriteLine($"Você Escolheu -> {jogador}");
        Console.WriteLine($"Computador Escolheu -> {escolhaPC}");
        Console.WriteLine("");
        
        if (jogador == escolhaPC)
        {
            Console.WriteLine("Empate!");
            Thread.Sleep(3500);
            Console.Clear();
        }

        else if ((jogador == "pedra" && escolhaPC == "tesoura") ||
                 (jogador == "papel" && escolhaPC == "pedra") ||
                 (jogador == "tesoura" && escolhaPC == "papel"))
        {
            Console.WriteLine("Você Ganhou!");
            pontosJG++;
            Thread.Sleep(3500);
            Console.Clear();
        }

        else
        {
            Console.WriteLine("Você Perdeu!");
            pontosPC++;
            Thread.Sleep(3500);
            Console.Clear();
        }

        Console.WriteLine($"A pontuação segue como: Jogador -> {pontosJG} x PC -> {pontosPC}.");
        Console.WriteLine("");
    }

    
