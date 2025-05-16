/*
using HilosParaTodos;

//MyEvents.finalizar = () => { Console.WriteLine("Suscriptor A"); };
//MyEvents.finalizar += () => { Console.WriteLine("Suscriptor B"); };

FinishEvent finalEvent = new FinishEvent();
Wrapper<Action> finalEventv2 = new Wrapper<Action>(() => { });

MiHilo t1 = new MiHilo("x", finalEventv2);
MiHilo t2 = new MiHilo("y", finalEventv2);

finalEvent.FinishAction += () => { Console.WriteLine("Suscriptor C"); };

t1.Start();
t2.Start();
*/
