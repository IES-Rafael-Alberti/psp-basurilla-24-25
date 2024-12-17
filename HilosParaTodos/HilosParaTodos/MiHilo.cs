namespace HilosParaTodos;

public class MiHilo
{
    Thread hilo;
    private string text;
    private Action finalAction;
    
    public MiHilo(string text, ref Action finalAction)
    {
        this.text = text;
        finalAction += () => { Console.WriteLine($"Hilo {text}"); };
        this.finalAction = finalAction;
        hilo = new Thread(_process);
    }

    public void Start()
    {
        hilo.Start();
    }

    void _process()
    {
        for (int i = 0; i < 1000; i++) Console.Write (text);
        finalAction?.Invoke();
        Console.WriteLine($"Ha terminado: {text}");
    }
}
