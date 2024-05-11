

Console.Write(" O tempo decorrido em (S) entre o raio e o trovão:");
Double Tempo = Convert.ToDouble(Console.ReadLine());

Double VelocidadeSom = RaioETrovao(340.29);
Console.WriteLine($"a distancia {VelocidadeSom:N5}");
 
double RaioETrovao(double VelocidadeSom)
{
    double distancia = VelocidadeSom * Tempo / 1000;
    return distancia;
}

