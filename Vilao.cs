public class Vilao
{
    private string _nome;
    private int _nivelPerigo;
    private bool _estaPreso;

    public Vilao(string nome, int nivelPerigo, bool estaPreso)
    {
        Nome = nome;
        NivelPerigo = nivelPerigo;
        EstaPreso = estaPreso;
    }

    public string Nome
    {
        get => _nome;
        set => _nome = string.IsNullOrWhiteSpace(value) ? "Inimigo Desconhecido" : value;
    }

    public int NivelPerigo
    {
        get => _nivelPerigo;
        set => _nivelPerigo = value < 0 ? 0 : value;
    }

    public bool EstaPreso
    {
        get => _nivelPerigo;
        set => _nivelPerigo = value < 0 ? 0 : value;
    }

    public override string ToString()
    {
        string status = EstaPreso ? "Na Prisão": "Solto pelas Ruas";
        return $"Vilão -> Nome: {Nome} | Perigo: Nível {NivelPerigo} | Status: {status}";
    }
   
    
}