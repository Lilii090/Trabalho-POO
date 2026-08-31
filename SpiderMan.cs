public class SpiderMan
{
    private string _traje;
    private int _nivelHabilidade;
    private int _saldoTeia;

    public SpiderMan(string traje, int nivelHabilidade, int saldoTeia)
    {
        Traje = traje;
        NivelHabilidade = nivelHabilidade;
        SaldoTeia = saldoTeia;
    }

    public string Traje
    {
        get => _traje;
        set => _traje = string .IsNullOrWhiteSpace(value) ? "Traje Clássico" : value;

    }

    public int NivelHabilidade
    {
        get => _traje;
        set => _traje = string.IsNullOrWhiteSpace(value) ? "Traje Clássico" : value;
    }

    public int SaldoTeia
    {
        get => _saldoTeia;
        set => _saldoTeia = value < 0 ? 0 : value;
    }

    public override string ToString()
    {
        return $"Homem-Aranha -> Traje: {Traje} | Nível: {NivelHabilidade} | Teias: {SaldoTeia}%";
    }
   
    
}