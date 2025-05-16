namespace HilosParaTodos;

public class Hilo2
{
    Random random = new();
    Thread hilo;
    public string Resultado = "ninguno todavía";
    public int Puntos;
    public void Juega()
    {
        hilo = new Thread(Tirada);
        hilo.Start();
    }

    private void Tirada()
    {
        List<string> tiradas = new List<string>(){ "piedra", "papel", "tijera" };
        Resultado = tiradas[random.Next(2)];
    }
}