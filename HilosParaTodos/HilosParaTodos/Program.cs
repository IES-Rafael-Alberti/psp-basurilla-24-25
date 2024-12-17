using HilosParaTodos;

Action finalizar = () => { Console.WriteLine("Suscriptor A"); };
finalizar += () => { Console.WriteLine("Suscriptor B"); };

MiHilo t1 = new MiHilo("x", ref finalizar);
MiHilo t2 = new MiHilo("y", ref finalizar);

finalizar += () => { Console.WriteLine("Suscriptor C"); };

t1.Start();
t2.Start();
