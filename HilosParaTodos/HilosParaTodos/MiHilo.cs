namespace HilosParaTodos;

public class MiHilo
{
    Thread hilo;
    private string text;
    private Wrapper<Action> finalizar;
    
    public MiHilo(string text, Wrapper<Action> finalizar)
    {
        this.text = text;
        this.finalizar = finalizar;
        finalizar.Value += () => { Console.WriteLine($"Hilo {text}"); };
        hilo = new Thread(_process);
    }

    public void Start()
    {
        hilo.Start();
    }

    void _process()
    {
        for (int i = 0; i < 1000; i++) Console.Write (text);
        finalizar.Value.Invoke();
        Console.WriteLine($"Ha terminado: {text}");
    }
}
