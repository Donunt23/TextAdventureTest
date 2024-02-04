namespace TBTBBG;

public abstract class Battle
{
    private static int _pHealth = Character.HitPoints;
    private static int _level = 1;
    private static int _mult;
    private static int _inc;
    private static readonly string[] Enemy =
    [
        "Gnoll", "Kobold", "Boar", "Swarm of Ravens", "Orc", "Wolf", 
        "Giant Goat", "Mirror Image of You", "Cockatrice", "Crazed Wizard"
    ];

    private static readonly int[] EHealth = [22, 5, 11, 24, 15, 11, 19, 20, 27, 34];
    public static void Combat()
        {
            var pDeath = true;
            var i = new Random().Next(1, 10);
            var eeHealth = EHealth[i];
            
            if (_inc == 5)
            {
                _inc = 0;
                Console.WriteLine("Congrats you leveled up!!!");
                ++_level;
                _mult += 2;
            }
            Console.WriteLine("Character: " + Character.Name + " is Level " + _level);
            while (_pHealth > 0 && eeHealth > 0)
            {
                //current game state
                Console.WriteLine("The player has " + _pHealth + " health.");
                Console.WriteLine("The enemy " + Enemy[i] + " has " + eeHealth + " health.");
                Console.WriteLine("Type: " +
                                  "'attack' to attack the enemy, " +
                                  "'block' to block an enemy attack, or " +
                                  "'drink' to use a potion.");

                //players choice
                var choice = Console.ReadLine();
                //enemy damage
                var enemyDamage = new Random().Next(1, 4);
                var playerDamage = new Random().Next(1, 4 + _mult);
                var potion = new Random().Next(2, 6 + _mult);

                //player action
                if (choice != null && choice.Equals("attack", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You attacked for " + playerDamage + " damage!");
                    eeHealth -= playerDamage;
                    Console.WriteLine("The enemy attacked for " + enemyDamage + " damage!");
                    _pHealth -= enemyDamage;
                }

                if (choice != null && choice.Equals("block", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You blocked against the attack!");
                    Console.WriteLine("The enemy would've dealt " + enemyDamage + " damage!");
                }

                if (choice != null && choice.Equals("drink", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You drank a potion healing for " + potion + " health.");
                    _pHealth += potion;
                    Console.WriteLine("The enemy attacked for " + enemyDamage + " damage!");
                    _pHealth -= enemyDamage;
                }

            }

            if (_pHealth <= 0)
            {
                Console.WriteLine("You died!");
                Option(pDeath);
            }

            if (eeHealth <= 0)
            {
                Console.WriteLine("You committed murder!");
                ++_inc;
                pDeath = false;
                Option(pDeath);
            }
        }

        private static void Option(Boolean swap)
        {
            if (swap) return;
            Console.WriteLine("Would you like to continue? Press 'c' to Continue, or Press 'e' to End");
            var c = Console.ReadLine();
            switch (c)
            {
                case "c":
                    Combat();
                    break;
                case "e":
                    Console.WriteLine("You retire your weapon, and go back to your home village.");
                    break;
            }
        }
}