using HilosParaTodos;

Hilo2 j1 = new Hilo2();
Hilo2 j2 = new Hilo2();

while (j1.Puntos < 2 && j2.Puntos < 2)
{
    j1.Juega();
    j2.Juega();
    Thread.Sleep(1000);
    Console.WriteLine($"{j1.Resultado} - {j2.Resultado}");
    if(j1.Resultado == j2.Resultado) continue;
    if (j1.Resultado == "tijeras")
    {
        if (j2.Resultado == "piedra")
        {
            // gana j2
            j2.Puntos++;
        }
        else
        {
            // gana j1 
            j1.Puntos++;
        }
    }
    if (j1.Resultado == "piedra")
    {
        if (j2.Resultado == "papel")
        {
            // gana j2
            j2.Puntos++;
        }
        else
        {
            // gana j1 
            j1.Puntos++;
        }
    }
    if (j1.Resultado == "papel")
    {
        if (j2.Resultado == "tijeras")
        {
            // gana j2
            j2.Puntos++;
        }
        else
        {
            // gana j1 
            j1.Puntos++;
        }
    }
}

if(j1.Puntos >= 2)
    Console.Write("gana J1  ::: ");
else
    Console.Write("gana J2  ::: ");
Console.WriteLine($"{j1.Puntos} - {j2.Puntos}");