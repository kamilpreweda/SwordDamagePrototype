using SwordDamagePrototype;

Console.WriteLine("Witaj! Wybierz rodzaj miecza: (aby zakończyć, wpisz inną wartość niż podane)");
Console.WriteLine("0 - ani magiczny, ani płonący, 1 - magiczny, 2 - płonący, 3 - magiczny i płonący");

char userInput = Console.ReadKey(true).KeyChar;

if (userInput == '0' || userInput == '1' || userInput == '2' || userInput == '3')
{
    Console.WriteLine($"Wybrałeś: {userInput}");
}
else return;

Random random = new Random();

var swordDamage = new SwordDamage();

swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);

Console.WriteLine($"Rzut: {swordDamage.Roll}");

swordDamage.SetMagic(userInput == '1' || userInput == '3');

swordDamage.SetFlaming(userInput == '2' || userInput == '3');

swordDamage.CalculateDamage();

Console.WriteLine($"punkty obrażeń: \n(Rzut {swordDamage.Roll} * Magiczny Mnożnik {swordDamage.MagicMultiplier}) \n+ Obrażenia Podstawowe 3 \n+ Obrażenia od ognia {swordDamage.FlamingDamage} \nWynik: {swordDamage.Damage}");



