using System;

    class Pessoa
{
    public  string nome;
    public string endereco;

    public int idade; 
public Pessoa(string nomeRecebido,string enderecoRecebido,int idadeRecebida){
    this.nome = nomeRecebido;
    this.endereco = enderecoRecebido;
    this.idade = idadeRecebida;
}

    internal static void Add(Pessoa p)
    {
        throw new NotImplementedException();
    }
}

