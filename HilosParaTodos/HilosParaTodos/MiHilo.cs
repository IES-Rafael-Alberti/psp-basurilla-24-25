namespace HilosParaTodos;

public class MiHilo
{
    Thread hilo;
    private string text;
    
    public MiHilo(string text)
    {
        this.text = text;
        MyEvents.finalizar += () => { Console.WriteLine($"Hilo {text}"); };
        hilo = new Thread(_process);
    }

    public void Start()
    {
        hilo.Start();
    }

    void _process()
    {
        for (int i = 0; i < 1000; i++) Console.Write (text);
        MyEvents.finalizar?.Invoke();
        Console.WriteLine($"Ha terminado: {text}");
    }
}
