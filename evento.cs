using System;

class Evento
{
    private List<string> pessoasListadas;

    public string nome { get; set; }
    public string local { get; set; }
    public float valor { get; set; }

    public List<string> listaPessoas { get; set; }

    public Evento(string nomeCriado, string? localCriado, float valorCriado)
    {
        this.pessoasListadas = new List<string>();
        this.listaPessoas = pessoasListadas;

        this.nome = nomeCriado;
        this.local = localCriado ?? string.Empty;
        this.valor = valorCriado;
    }

    public string verificarEntrada(int limite = 2)
    {
        if (listaPessoas.Count > limite)
        {
            return $"Limite Excedido! Essas estarão no evento: ";
        }
        else
        {
            return $"Quantidade de pessoas permitidas! Total: {listaPessoas.Count}";
        }
    }
}