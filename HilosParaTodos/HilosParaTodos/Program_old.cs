/*
string SeTermino = "";
bool SeHaEnterado = false;

Action finalizar;

finalizar = () =>
{ Console.WriteLine();Console.WriteLine("Alguien ha terminado"); };

Thread t1 = new Thread (WriteY); // Kick off a new thread
Thread t2 = new Thread (WriteX); // Kick off a new thread
t1.Start(); // running WriteY()
t2.Start(); // running WriteX()
while (SeTermino.Length == 0)
{
}
Console.WriteLine();
SeHaEnterado = true;
Console.WriteLine ($"Ha ganado {SeTermino}");

void WriteY()
{
    WriteText("y");
}
void WriteX()
{
    WriteText("x");
}

void WriteText(string text)
{
    for (int i = 0; i < 1000 && SeTermino==""; i++) Console.Write (text);
    if(SeTermino=="") SeTermino = text;
    while (!SeHaEnterado) {}
    finalizar?.Invoke();
    Console.WriteLine($"Ha terminado: {text}");
}

*/