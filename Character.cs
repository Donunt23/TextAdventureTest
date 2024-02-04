namespace TBTBBG;

public abstract class Character
{
    public static int SStr { get; private set; } = 0;
    public static int SDex { get; private set; } = 0;
    public static int SInt { get; private set; } = 0;
    public static int SWis { get; private set; } = 0;
    public static int SCha { get; private set; } = 0;
    private static int _sCon = 0;
    private static int _sMod = 0;

    public static string? Name;
    private static string? _pClass;
    private static string? _subClass;
    private static string? _race;
    public static int HitPoints;

    private static readonly string Key = Console.ReadKey().Key.ToString();

    private const string Playerclass = "Your recommended class: ";

    public static void NameChar()
    {
        Console.Write("Name your character: ");
        Name = Console.ReadLine();
    }

    public static string? GetRace()
    {
        Console.WriteLine("Select your race");
        Console.WriteLine("----------------------");
        Console.WriteLine("Type 'Dragonborn' for Dragonborn");
        Console.WriteLine("Type 'Dwarf' for Dwarf");
        Console.WriteLine("Type 'Elf' for Elf");
        Console.WriteLine("Type 'Gnome' for Gnome");
        Console.WriteLine("Type 'Half-Elf' for Half-Elf");
        Console.WriteLine("Type 'Halfling' for Halfling");
        Console.WriteLine("Type 'Half-Orc' for Half-Orc");
        Console.WriteLine("Type 'Human' for Human");
        Console.WriteLine("Type 'Tiefling' for Tiefling");
        Console.WriteLine("Type 'Githyanki' for Githyanki");
        Console.WriteLine("----------------------");
        
        var choice = Console.ReadLine();

        if (choice.Equals("Dragonborn", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Select Draconic Ancestry");
            Console.WriteLine("----------------------");
            Console.WriteLine("Black" +
                              "\nBlue" +
                              "\nBrass" +
                              "\nBronze" +
                              "\nCopper" +
                              "\nGold" +
                              "\nGreen" +
                              "\nRed" +
                              "\nSilver" +
                              "\nWhite" +
                              "\n----------------------");
            
            var sr = Console.ReadLine();

            if (sr.Equals("Black", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Black Dragonborn";
            }
            if (sr.Equals("Blue", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Blue Dragonborn";
            }
            if (sr.Equals("Brass", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Brass Dragonborn";
            }
            if (sr.Equals("Bronze", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Bronze Dragonborn";
            }
            if (sr.Equals("Copper", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Copper Dragonborn";
            }
            if (sr.Equals("Gold", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Gold Dragonborn";
            }
            if (sr.Equals("Green", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Green Dragonborn";
            }
            if (sr.Equals("Red", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Red Dragonborn";
            }
            if (sr.Equals("Silver", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Silver Dragonborn";
            }
            if (sr.Equals("White", StringComparison.OrdinalIgnoreCase))
            {
                _race = "White Dragonborn";
            }
        }

        if (choice.Equals("Dwarf", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Select your sub-race");
            Console.WriteLine("----------------------");
            Console.WriteLine("Gold" +
                              "\nShield" +
                              "\nDuergar" +
                              "\n----------------------");
            
            var sr = Console.ReadLine();

            if (sr.Equals("Gold", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Gold Dwarf";
            }
            if (sr.Equals("Shield", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Shield Dwarf";
            }
            if (sr.Equals("Duergar", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Duergar";
            }
        }

        if (choice.Equals("Elf", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Select your sub-race");
            Console.WriteLine("----------------------");
            Console.WriteLine("High" +
                              "\nWood" +
                              "\nDrow" +
                              "\n----------------------");
            
            var sr = Console.ReadLine();

            if (sr.Equals("High", StringComparison.OrdinalIgnoreCase))
            {
                _race = "High Elf";
            }
            if (sr.Equals("Wood", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Wood Elf";
            }
            if (sr.Equals("Drow", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Drow";
            }
        }

        if (choice.Equals("Gnome", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Select your sub-race");
            Console.WriteLine("----------------------");
            Console.WriteLine("Deep" +
                              "\nForest" +
                              "\nRock" +
                              "\n----------------------");
            
            var sr = Console.ReadLine();

            if (sr.Equals("Deep", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Deep Gnome";
            }
            if (sr.Equals("Forest", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Forest Gnome";
            }
            if (sr.Equals("Rock", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Rock Gnome";
            }
        }

        if (choice.Equals("Half-Elf", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Select your sub-race");
            Console.WriteLine("----------------------");
            Console.WriteLine("High" +
                              "\nWood" +
                              "\nDrow" +
                              "\n----------------------");
            
            var sr = Console.ReadLine();

            if (sr.Equals("High", StringComparison.OrdinalIgnoreCase))
            {
                _race = "High Half-Elf";
            }
            if (sr.Equals("Wood", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Wood Half-Elf";
            }
            if (sr.Equals("Drow", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Drow Half-Elf";
            }
        }

        if (choice.Equals("Halfling", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Select your sub-race");
            Console.WriteLine("----------------------");
            Console.WriteLine("Lightfoot" +
                              "\nStrongheart" +
                              "\n----------------------");
            
            var sr = Console.ReadLine();

            if (sr.Equals("Lightfoot", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Lightfoot Halfling";
            }
            if (sr.Equals("Strongheart", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Strongheart Halfling";
            }
        }

        if (choice.Equals("Half-Orc", StringComparison.OrdinalIgnoreCase))
        {
            _race = "Half-orc";
        }

        if (choice.Equals("Human", StringComparison.OrdinalIgnoreCase))
        {
            _race = "Human";
        }

        if (choice.Equals("Tiefling", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Select your sub-race");
            Console.WriteLine("----------------------");
            Console.WriteLine("Asmodeus" +
                              "\nMephistopheles" +
                              "\nZariel" +
                              "\n----------------------");
            
            var sr = Console.ReadLine();

            if (sr.Equals("Asmodeus", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Asmodeus Tiefling";
            }
            if (sr.Equals("Mephistopheles", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Mephistopheles Tiefling";
            }
            if (sr.Equals("Zariel", StringComparison.OrdinalIgnoreCase))
            {
                _race = "Zariel Tiefling";
            }
        }

        if (choice.Equals("Githyanki", StringComparison.OrdinalIgnoreCase))
        {
            _race = "Githyanki";
        }

        return _race;
    }

    public static void GetStats()
    {
        Console.WriteLine("\nPress 'ENTER' to roll for Strength");
        Console.ReadLine();
        
        if (Key.ToUpper() == "ENTER")
        {
            SStr = RollStats(SStr);
        }
        
        Console.WriteLine("Press 'ENTER' to roll for Dexterity");
        Console.ReadLine();
        
        if (Key.ToUpper() == "ENTER")
        {
            SDex = RollStats(SDex);
        }
        
        Console.WriteLine("Press 'ENTER' to roll for Constitution");
        Console.ReadLine();
        
        if (Key.ToUpper() == "ENTER")
        {
            _sCon = RollStats(_sCon);
        }
        
        Console.WriteLine("Press 'ENTER' to roll for Intelligence");
        Console.ReadLine();
        
        if (Key.ToUpper() == "ENTER")
        {
            SInt = RollStats(SInt);
        }
        
        Console.WriteLine("Press 'ENTER' to roll for Wisdom");
        Console.ReadLine();
        
        if (Key.ToUpper() == "ENTER")
        {
            SWis = RollStats(SWis);
        }
        
        Console.WriteLine("Press 'ENTER' to roll for Charisma");
        Console.ReadLine();
        
        if (Key.ToUpper() == "ENTER")
        {
            SCha = RollStats(SCha);
        }
    }

    private static int RollStats(int stat)
    {
        int total = 0;
        int count = 4;
        int sides = 6;
        
        List<int> rolls = new List<int>();

        for (int i = 0; i < count; i++)
        {
            int rRoll = new Random().Next(1, sides + 1);

            rolls.Add(rRoll);
        }

        rolls.Sort();
        
        for (int i = 1; i < rolls.Count; i++)
        {
            total += rolls[i];
        }
        
        //Console.WriteLine("total: " + total);
        return total;
    }

    private static int AbilityMods(int stat)
    {
        _sMod = ((int)(stat - 10) / 2);
        return _sMod;
    }

    public static void RecClass(int sStr, int sDex, int sInt, int sWis, int sCha)
    {
        //Barbarian - STR
        if (sStr > sDex && sStr > sInt && sStr > sWis && sStr > sCha)
        {
            Console.WriteLine(Playerclass + "\nBarbarian");
        }
        //Bard - CHA & DEX
        if (sCha > sStr && sCha == sDex && sCha > sInt && sCha > sWis)
        {
            Console.WriteLine(Playerclass + "\nBard");
        }
        //Cleric - WIS & INT
        if (sWis > sStr && sWis > sDex && sWis == sInt && sWis > sCha)
        {
            Console.WriteLine(Playerclass + "\nCleric");
        }
        //Druid - WIS
        if (sWis > sStr && sWis > sDex && sWis > sInt && sWis > sCha)
        {
            Console.WriteLine(Playerclass + "\nDruid");
        }
        //Fighter - STR & DEX
        if (sStr == sDex && sStr > sInt && sStr > sWis && sStr > sCha)
        {
            Console.WriteLine(Playerclass + "\nFighter");
        }
        //Monk - WIS & DEX
        if (sWis > sStr && sWis == sDex && sWis > sInt && sWis > sCha)
        {
            Console.WriteLine(Playerclass + "\nMonk");
        }
        //Paladin - STR & CHA
        if (sStr > sDex && sStr > sInt && sStr > sWis && sStr == sCha)
        {
            Console.WriteLine(Playerclass + "\nPaladin");
        }
        //Ranger - DEX & WIS
        if (sDex > sStr && sDex > sInt && sDex == sWis && sDex > sCha)
        {
            Console.WriteLine(Playerclass + "\nRanger");
        }
        //Rogue - DEX
        if (sDex > sStr && sDex > sInt && sDex > sWis && sDex > sCha)
        {
            Console.WriteLine(Playerclass + "\nRogue");
        }
        //Sorcerer - CHA
        if (sCha > sStr && sCha > sDex && sCha > sInt && sCha > sWis)
        {
            Console.WriteLine(Playerclass + "\nSorcerer");
        }
        //Warlock - CHA & WIS
        if (sCha > sStr && sCha > sDex && sCha > sInt && sCha == sWis)
        {
            Console.WriteLine(Playerclass + "\nWarlock");
        }
        //Wizard - INT
        if (sInt > sStr && sInt > sDex && sInt > sWis && sInt > sCha)
        {
            Console.WriteLine(Playerclass + "\nWizard");
        }
        //STR & INT
        if (sStr > sDex && sStr == sInt && sStr > sWis && sStr > sCha)
        {
            Console.WriteLine(Playerclass + "\nBarbarian \nWizard");
        }
        //STR & WIS
        if (sStr > sDex && sStr > sInt && sStr == sWis && sStr > sCha)
        {
            Console.WriteLine(Playerclass + "\nBarbarian \nDruid");
        }
        //DEX & INT
        if (sDex > sStr && sDex == sInt && sDex > sWis && sDex > sCha)
        {
            Console.WriteLine(Playerclass + "\nRogue \nWizard");
        }
        //INT & CHA
        if (sInt > sStr && sInt > sDex && sInt > sWis && sInt == sCha)
        {
            Console.WriteLine(Playerclass + "\nWizard \nSorcerer");
        }
        else
            Console.WriteLine("");
    }

    public static string? SelectClass()
    {
        Console.WriteLine("Select your class");
        Console.WriteLine("Type 'class' to view all classes and their primary stats");

        var choice = Console.ReadLine();

        if (choice.Equals("class", StringComparison.OrdinalIgnoreCase))
        {
            Console.Write("----------------------");
            Console.Write("\nBarbarian" +
                          "\nPrimary Stat: Strength" +
                          "\nBard" +
                          "\nPrimary Stats: Charisma & Dexterity" +
                          "\nCleric" +
                          "\nPrimary Stats: Wisdom & Intelligence" +
                          "\nDruid" +
                          "\nPrimary Stat: Wisdom" +
                          "\nFighter" +
                          "\nPrimary Stats: Strength & Dexterity" +
                          "\nMonk" +
                          "\nPrimary Stats: Dexterity & Wisdom" +
                          "\nPaladin" +
                          "\nPrimary Stats: Strength & Charisma" +
                          "\nRanger" +
                          "\nPrimary Stat: Dexterity & Wisdom" +
                          "\nRogue" +
                          "\nPrimary Stat: Dexterity" +
                          "\nSorcerer" +
                          "\nPrimary Stat: Charisma" +
                          "\nWarlock" +
                          "\nPrimary Stat: Wisdom & Charisma" +
                          "\nWizard" +
                          "\nPrimary Stat: Intelligence" +
                          "\n----------------------");
        }

        if (choice.Equals("Barbarian", StringComparison.OrdinalIgnoreCase))
        {
            _pClass = "Barbarian";
            HitPoints = 12 + AbilityMods(_sCon);
            
            Console.WriteLine("Choose your subclass");
            Console.WriteLine("----------------------" +
                              "\nBerserker" +
                              "\nWildheart" +
                              "\nWild Magic" +
                              "\n----------------------");
            
            var sc = Console.ReadLine();
            
            if (sc.Equals("Berserker", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Berserker";
            }
            if (sc.Equals("Wildheart", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Wildheart";
            }
            if (sc.Equals("Wild Magic", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Wild Magic";
            }

            return _subClass;
        }
        if (choice.Equals("Bard", StringComparison.OrdinalIgnoreCase))
        {
            _pClass = "Bard";
            HitPoints = 8 + AbilityMods(_sCon);
            
            Console.WriteLine("Choose your subclass");
            Console.WriteLine("----------------------" +
                              "\nCollege of Lore" +
                              "\nCollege of Valour" +
                              "\nCollege of Swords" +
                              "\n----------------------");

            var sc = Console.ReadLine();
            
            if (sc.Equals("College of Lore", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "College of Lore";
            }
            if (sc.Equals("College of Valour", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "College of Valour";
            }
            if (sc.Equals("College of Swords", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "College of Swords";
            }

            return _subClass;
        }
        if (choice.Equals("Cleric", StringComparison.OrdinalIgnoreCase))
        {
            _pClass = "Cleric";
            HitPoints = 8 + AbilityMods(_sCon);
            
            Console.WriteLine("Choose your domain");
            Console.WriteLine("----------------------" +
                              "\nLife Domain" +
                              "\nLight Domain" +
                              "\nTrickery Domain" +
                              "\nKnowledge Domain" +
                              "\nNature Domain" +
                              "\nTempest Domain" +
                              "\nWar Domain" +
                              "\n----------------------");
            
            var sc = Console.ReadLine();
            
            if (sc.Equals("Life Domain", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Life Domain";
            }
            if (sc.Equals("Light Domain", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Light Domain";
            }
            if (sc.Equals("Trickery Domain", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Trickery Domain";
            }
            if (sc.Equals("Knowledge Domain", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Knowledge Domain";
            }
            if (sc.Equals("Nature Domain", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Nature Domain";
            }
            if (sc.Equals("Tempest Domain", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Tempest Domain";
            }
            if (sc.Equals("War Domain", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "War Domain";
            }

            return _subClass;
        }
        if (choice.Equals("Druid", StringComparison.OrdinalIgnoreCase))
        {
            _pClass = "Druid";
            HitPoints = 8 + AbilityMods(_sCon);
            
            Console.WriteLine("Choose your subclass");
            Console.WriteLine("----------------------" +
                              "\nCircle of the Land" +
                              "\nCircle of the Moon" +
                              "\nCircle of the Spores" +
                              "\n----------------------");
            
            var sc = Console.ReadLine();
            
            if (sc.Equals("Circle of the Land", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Circle of the Land";
            }
            if (sc.Equals("Circle of the Moon", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Circle of the Moon";
            }
            if (sc.Equals("Circle of the Spores", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Circle of the Spores";
            }

            return _subClass;
        }
        if (choice.Equals("Fighter", StringComparison.OrdinalIgnoreCase))
        {
            _pClass = "Fighter";
            HitPoints = 10 + AbilityMods(_sCon);
            
            Console.WriteLine("Choose your subclass");
            Console.WriteLine("----------------------" +
                              "\nBattle Master" +
                              "\nEldritch Knight" +
                              "\nChampion" +
                              "\n----------------------");
            
            var sc = Console.ReadLine();
            
            if (sc.Equals("Battle Master", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Battle Master";
            }
            if (sc.Equals("Eldritch Knight", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Eldritch Knight";
            }
            if (sc.Equals("Champion", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Champion";
            }

            return _subClass;
        }
        if (choice.Equals("Monk", StringComparison.OrdinalIgnoreCase))
        {
            _pClass = "Monk";
            HitPoints = 8 + AbilityMods(_sCon);
            
            Console.WriteLine("Choose your subclass");
            Console.WriteLine("----------------------" +
                              "\nWay of the Four Elements" +
                              "\nWay of the Open Hand" +
                              "\nWay of the Shadow" +
                              "\n----------------------");
            
            var sc = Console.ReadLine();
            
            if (sc.Equals("Way of the Four Elements", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Way of the Four Elements";
            }
            if (sc.Equals("Way of the Open Hand", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Way of the Open Hand";
            }
            if (sc.Equals("Way of the Shadow", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Way of the Shadow";
            }

            return _subClass;
        }
        if (choice.Equals("Paladin", StringComparison.OrdinalIgnoreCase))
        {
            _pClass = "Paladin";
            HitPoints = 10 + AbilityMods(_sCon);
            
            Console.WriteLine("Choose your oath");
            Console.WriteLine("----------------------" +
                              "\nOath of the Ancients" +
                              "\nOath of Devotion" +
                              "\nOath of Vengeance" +
                              "\n----------------------");
            
            var sc = Console.ReadLine();
            
            if (sc.Equals("Oath of the Ancients", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Oath of the Ancients";
            }
            if (sc.Equals("Oath of Devotion", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Oath of Devotion";
            }
            if (sc.Equals("Oath of Vengeance", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Oath of Vengeance";
            }

            return _subClass;
        }
        if (choice.Equals("Ranger", StringComparison.OrdinalIgnoreCase))
        {
            _pClass = "Ranger";
            HitPoints = 10 + AbilityMods(_sCon);
            
            Console.WriteLine("Choose your subclass");
            Console.WriteLine("----------------------" +
                              "\nHunter" +
                              "\nBeast Master" +
                              "\nGloom Stalker" +
                              "\n----------------------");
            
            var sc = Console.ReadLine();
            
            if (sc.Equals("Hunter", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Hunter";
            }
            if (sc.Equals("Beast Master", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Beast Master";
            }
            if (sc.Equals("Gloom Stalker", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Gloom Stalker";
            }

            return _subClass;
        }
        if (choice.Equals("Rogue", StringComparison.OrdinalIgnoreCase))
        {
            _pClass = "Rogue";
            HitPoints = 8 + AbilityMods(_sCon);
            
            Console.WriteLine("Choose your subclass");
            Console.WriteLine("----------------------" +
                              "\nArcane Trickster" +
                              "\nThief" +
                              "\nAssassin" +
                              "\n----------------------");
            
            var sc = Console.ReadLine();
            
            if (sc.Equals("Arcane Trickster", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Arcane Trickster";
            }
            if (sc.Equals("Thief", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Thief";
            }
            if (sc.Equals("Assassin", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Assassin";
            }

            return _subClass;
        }
        if (choice.Equals("Sorcerer", StringComparison.OrdinalIgnoreCase))
        {
            _pClass = "Sorcerer";
            HitPoints = 6 + AbilityMods(_sCon);
            
            Console.WriteLine("Choose your subclass");
            Console.WriteLine("----------------------" +
                              "\nWild Magic" +
                              "\nDraconic Bloodline" +
                              "\nStorm Sorcery" +
                              "\n----------------------");
            
            var sc = Console.ReadLine();
            
            if (sc.Equals("Wild Magic", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Wild Magic";
            }
            if (sc.Equals("Draconic Bloodline", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Draconic Bloodline";
            }
            if (sc.Equals("Storm Sorcery", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "Storm Sorcery";
            }

            return _subClass;
        }
        if (choice.Equals("Warlock", StringComparison.OrdinalIgnoreCase))
        {
            _pClass = "Warlock";
            HitPoints = 8 + AbilityMods(_sCon);
            
            Console.WriteLine("Choose your subclass");
            Console.WriteLine("----------------------" +
                              "\nThe Fiend" +
                              "\nThe Great Old One" +
                              "\nThe Archfey" +
                              "\n----------------------");
            
            var sc = Console.ReadLine();
            
            if (sc.Equals("The Fiend", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "The Fiend";
            }
            if (sc.Equals("The Great Old One", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "The Great Old One";
            }
            if (sc.Equals("The Archfey", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "The Archfey";
            }

            return _subClass;
        }
        if (choice.Equals("Wizard", StringComparison.OrdinalIgnoreCase))
        {
            _pClass = "Wizard";
            HitPoints = 6 + AbilityMods(_sCon);
            
            Console.WriteLine("Choose your school");
            Console.WriteLine("----------------------" +
                              "\nSchool of Abjuration" +
                              "\nSchool of Conjuration" +
                              "\nSchool of Divination" +
                              "\nSchool of Enchantment" +
                              "\nSchool of Evocation" +
                              "\nSchool of Illusion" +
                              "\nSchool of Necromancy" +
                              "\nSchool of Transmutation" +
                              "\n----------------------");
            
            var sc = Console.ReadLine();
            
            if (sc.Equals("School of Abjuration", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "School of Abjuration";
            }
            if (sc.Equals("School of Conjuration", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "School of Conjuration";
            }
            if (sc.Equals("School of Divination", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "School of Divination";
            }
            if (sc.Equals("School of Enchantment", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "School of Enchantment";
            }
            if (sc.Equals("School of Evocation", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "School of Evocation";
            }
            if (sc.Equals("School of Illusion", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "School of Illusion";
            }
            if (sc.Equals("School of Necromancy", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "School of Necromancy";
            }
            if (sc.Equals("School of Transmutation", StringComparison.OrdinalIgnoreCase))
            {
                _subClass = "School of Transmutation";
            }

            return _subClass;
        }
        
        return _pClass;
    }

    public static void DisplayCharacter()
    {
        Console.WriteLine("\nName: " + Name);
        Console.WriteLine("Race: " + _race);
        Console.WriteLine("Hit Points: " + HitPoints);
        Console.WriteLine("Class: " + _pClass);
        Console.WriteLine("Subclass: " + _subClass);
        Console.WriteLine("----------------------");
        Console.WriteLine("Strength: " + SStr + " (" + AbilityMods(SStr) + ")");
        Console.WriteLine("Dexterity: " + SDex + " (" + AbilityMods(SDex) + ")");
        Console.WriteLine("Constitution: " + _sCon + " (" + AbilityMods(_sCon) + ")");
        Console.WriteLine("Intelligence: " + SInt + " (" + AbilityMods(SInt) + ")");
        Console.WriteLine("Wisdom: " + SWis + " (" + AbilityMods(SWis) + ")");
        Console.WriteLine("Charisma: " + SCha + " (" + AbilityMods(SCha) + ")");
        Console.WriteLine("----------------------");
        Console.WriteLine("Passive Wisdom: " + (AbilityMods(SWis) + 10));
        Console.WriteLine("----------------------");
    }
    
}

/* Stuff I want to add
Skills
Proficiencies
Equipment
Alignments
Personality, Ideals, Bonds, Flaws
Armor Class
Attacks & Spells
Languages
Features
Passive Wisdom
Make prompts NOT caps sensitive
*/