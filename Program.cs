class Program
{
    static void Main()
    {
        
        Pessoa pessoa1 = new Pessoa("Juba", "Ilha",19);
        Pessoa pessoa2 = new Pessoa("Diego", "Ilha", 20);
       
        Console.Write("Nome do evento: ");
        string nomeEvento = Console.ReadLine();

        Console.Write("Local do evento: ");
        string localEvento = Console.ReadLine();

        Console.Write("O evento é pago? (s/n): ");
        string resposta = Console.ReadLine();

        float valorEvento = 0;

        if (resposta.Equals("s", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Write("Digite o valor do evento: ");
            valorEvento = float.Parse(Console.ReadLine());
        }

        Evento evento = new Evento(nomeEvento, localEvento, valorEvento);

        
        List<Pessoa> pessoas = new List<Pessoa> { pessoa1, pessoa2};

        
        foreach (Pessoa pessoa in pessoas)
        {
            evento.listaPessoas.Add(pessoa.nome); 
        

        // Exibir informações
        Console.WriteLine($"\nEvento: {evento.nome}");
        Console.WriteLine($"Local: {evento.local}");
        Console.WriteLine($"Valor: {(evento.valor == 0 ? "Gratuito" : $"R$ {evento.valor}")}");
        Console.WriteLine("Participantes:");

        foreach (string nomePessoa in evento.listaPessoas)
        {
            Console.WriteLine($"- {nomePessoa}, {pessoa.endereco}, {pessoa.idade} anos");
        }
        Console.WriteLine("\n" + evento.verificarEntrada(2));
    }
}
}