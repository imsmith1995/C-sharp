using InterfacesTutorial;

Console.WriteLine("Interfaces Tutorial");

Boxer joe = new();
Parrot kiki = new();
Frog samuel = new();
ISpeakable joe2 = new Boxer();

List<ISpeakable> pets = new()
{
 joe, kiki, samuel
};

foreach (ISpeakable pet in pets)
{
    pet.Scream();
}