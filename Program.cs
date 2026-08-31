Console.WriteLine("=== 1. ===");

Retangulo r1 = new Retangulo(10, 5);
Retangulo r2 = new Retangulo(3, 3);

Console.WriteLine(r1);
Console.WriteLine(r2);

r1.Largura = 15;
r2.Altura = -2;

Console.WriteLine("Após alterações:");
Console.WriteLine(r1);
Console.WriteLine(r2);
Console.WriteLine();

Console.WriteLine("=== 2. ===");

SpiderMan spider1 = new SpiderMan("Clássico Azul e Vermelho", 85, 100);
SpiderMan spider2 = new SpiderMan("Traje de Ferro (Tony Stark)", 95, 80);

Console.WriteLine(spider1);
Console.WriteLine(spider2);

spider1.SaldoTeia = 45;
spider2.NivelHabilidade = -10;

Console.WriteLine("Após alterações:");
Console.WriteLine(spider1);
Console.WriteLine(spider2);
Console.WriteLine();

Console.WriteLine("=== 3. ===");

Vilao v1 = new Vilao("Duende Verde", 90, false);
Vilao v2 = new Vilao("Doutor Octopus", 85, true);

Console.WriteLine(v1);
Console.WriteLine(v2);

v1.EstaPreso = true;
v2.NivelPerigo = 95;

Console.WriteLine("Após alterações:");
Console.WriteLine(v1);
Console.WriteLine(v2);




    