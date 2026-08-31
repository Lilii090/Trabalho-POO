
    public class Retangulo
{
    private double largura;
    private double altura;

    public Retangulo(double largura, double altura)
    {
        largura = largura;
        altura =  altura;
    }

    public double Largura
    {
        get {return largura;}
        set {largura = value > 0 ? value : 1.0;}
    }

    public double altura
    {
        get {return altura;}
        set {altura = value > 0 ? value: 1.0;}
    }

    public double CalcularArea()
    {
        return largura * altura;
    }

    public override string ToString()
    {
        return $"Retângulo: Largura: {Largura} | Altura: {altura} | Àrea: {CalcularArea()}";
    }
    
    }
