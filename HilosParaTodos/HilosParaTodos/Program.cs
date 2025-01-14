using HilosParaTodos;

MyEvents.finalizar = () => { Console.WriteLine("Suscriptor A"); };
MyEvents.finalizar += () => { Console.WriteLine("Suscriptor B"); };

MiHilo t1 = new MiHilo("x");
MiHilo t2 = new MiHilo("y");

MyEvents.finalizar += () => { Console.WriteLine("Suscriptor C"); };

t1.Start();
t2.Start();
