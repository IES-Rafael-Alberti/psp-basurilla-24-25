// See https://aka.ms/new-console-template for more information
Action<Character> myAction;
myAction = (c) => Console.WriteLine($"Viva {c.Name}!!!");
Character personajillo = new Character() { Name = "Nico" };
myAction(personajillo);

Console.WriteLine();
myAction += (c) => Console.WriteLine($"Viva la cabeza de {c.Name}!!!");
myAction.Invoke(personajillo);
myAction.Invoke(new Character() { Name = "Fran" });
// Console.WriteLine();
// Action cabecilla = (Action) myAction.GetInvocationList()[1];
//myAction.GetInvocationList();

public class Character
{
    public string Name { get; set; }
    
}
