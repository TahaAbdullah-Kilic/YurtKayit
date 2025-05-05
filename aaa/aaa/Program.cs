using System;
using System.Collections.Generic;
using static Program;

class Program
{
    public static Player player = new Player();

    public interface IChapter
    {
        void PlayChapter();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Text-Based Adventure Game!");
        Console.WriteLine("Enter your character's name:");

        string? inputName = Console.ReadLine();
        player.Name = !string.IsNullOrWhiteSpace(inputName) ? inputName : "Adventurer";

        player.ChooseAttributes();

        IChapter[] chapters = {
            new Chapter1(),
            new Chapter2(),
            new Chapter3(),
            new Chapter4(),
            new Chapter5(),
            new Chapter6(),
            new Chapter7(),
            new Chapter8(),
            new Chapter9(),
            new Chapter10()
        };

        foreach (var chapter in chapters)
        {
            chapter.PlayChapter();
            if (player.Health <= 0)
            {
                Console.WriteLine("You have perished. Game Over.");
                return;
            }
        }

        Console.WriteLine("Congratulations! You have completed the game!");
        Console.WriteLine("\nFinal Inventory:");
        foreach (var item in player.Inventory)
        {
            if (!string.IsNullOrWhiteSpace(item))
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}

public class Player
{
    public string Name { get; set; } = "Unnamed Hero";
    public int Strength { get; set; } = 10;
    public int Agility { get; set; } = 10;
    public int Intelligence { get; set; } = 10;
    public int Wisdom { get; set; } = 10;
    public int Health { get; set; } = 100;
    public int Mana { get; set; } = 50;
    public int Stamina { get; set; } = 50;

    public List<string> Inventory { get; private set; } = new List<string>();

    public void TakeDamage(int amount)
    {
        Health = Math.Max(0, Health - amount);
        Console.WriteLine($"You took {amount} damage. Remaining health: {Health}");
    }

    public void GainSkillPoint(int i)
    {
        Console.WriteLine("Choose an attribute to improve: Strength, Agility, Intelligence, or Wisdom.");
        string? choice = Console.ReadLine()?.ToLower();
        

        switch (choice)
        {
            case "strength":
                Strength += i;
                Console.WriteLine("Strength increased!");
                break;
            case "agility":
                Agility += i;
                Console.WriteLine("Agility increased!");
                break;
            case "intelligence":
                Intelligence += i;
                Console.WriteLine("Intelligence increased!");
                break;
            case "wisdom":
                Wisdom += i;
                Console.WriteLine("Wisdom increased!");
                break;
            default:
                Console.WriteLine("Invalid choice. No changes made.");
                break;
        }
    }

    public void ChooseAttributes()
    {
        int i = 0;
        

        while (i<10)
        {
            Console.WriteLine("Choose how much skill points you want to increase from 1-10.");
            int sayiarttir = Convert.ToInt32(Console.ReadLine());
            if ((sayiarttir + i) > 10)
            {
                Console.WriteLine("Limitten daha yuksek ekleme yaptınız daha küçük bir deger girin.");
                sayiarttir = 0;
                continue;
            }
            i += sayiarttir;
            GainSkillPoint(sayiarttir);
            sayiarttir = 0;
        }
    }
}

class Chapter1 : Program.IChapter
{
    public void PlayChapter()
    {
        Console.WriteLine("\n--- Chapter 1: The Beginning ---");
        Console.WriteLine($"You, {Program.player.Name}, awaken in a peaceful village.");
        Console.WriteLine("A strange merchant offers you three items:");

        string[] items = { "A sword", "A spellbook", "A shield" };
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }

        string? choice;
        do
        {
            Console.WriteLine("Choose an item (1, 2, or 3):");
            choice = Console.ReadLine();
        } while (choice != "1" && choice != "2" && choice != "3");

        switch (choice)
        {
            case "1":
                Console.WriteLine("You choose the sword and feel a surge of power.");
                Program.player.Strength += 5;
                Program.player.Inventory.Add("Sword");
                break;
            case "2":
                Console.WriteLine("You choose the spellbook and feel your mind expand.");
                Program.player.Intelligence += 5;
                Program.player.Inventory.Add("Spellbook");
                break;
            case "3":
                Console.WriteLine("You choose the shield and feel safer.");
                Program.player.Wisdom += 5;
                Program.player.Inventory.Add("Shield");
                break;
        }
    }
}

class Chapter2 : Program.IChapter
{
    public void PlayChapter()
    {
        Console.WriteLine("\n--- Chapter 2: A Mysterious Stranger ---");
        Console.WriteLine("A cloaked figure appears and challenges you to a riddle.");
        Console.WriteLine("Answer correctly, or face the consequences!");
        Console.WriteLine("Riddle: I speak without a mouth and hear without ears. I have no body, but I come alive with wind. What am I?");

        string? answer = Console.ReadLine()?.ToLower();
        if (answer == "echo")
        {
            Console.WriteLine("Correct! The stranger nods and vanishes.");
            Program.player.Wisdom += 5;
        }
        else
        {
            Console.WriteLine("Wrong! The stranger curses you.");
            Program.player.TakeDamage(10);
        }
    }
}

class Chapter3 : Program.IChapter
{
    public void PlayChapter()
    {
        Console.WriteLine("\n--- Chapter 3: Into the Forest ---");
        Console.WriteLine("You venture into a dark forest. Suddenly, wolves attack!");

        Console.WriteLine("You fight bravely but take some damage.");
        Program.player.TakeDamage(15);
    }
}

class Chapter4 : Program.IChapter
{
    public void PlayChapter()
    {
        Console.WriteLine("\n--- Chapter 4: The Abandoned Castle ---");
        Console.WriteLine("You discover an abandoned castle. Inside, a trap is triggered!");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"You dodge trap {i + 1}...");
            if (Program.player.Agility < 12)
            {
                Program.player.TakeDamage(5);
                Console.WriteLine("You weren't fast enough.");
            }
            else
            {
                Console.WriteLine("You evade the trap!");
            }
        }
    }
}
class Chapter5 : Program.IChapter
{
    public void PlayChapter()
    {
        Console.WriteLine("\n--- Chapter 5: The Ancient Tome ---");
        Console.WriteLine("You find an ancient tome of knowledge. Do you read it? (yes/no)");

        string? choice = Console.ReadLine()?.ToLower();
        if (choice == "yes")
        {
            Console.WriteLine("The tome grants you wisdom but saps your strength.");
            Program.player.Wisdom += 10;
            Program.player.TakeDamage(10);
        }
        else
        {
            Console.WriteLine("You leave the tome alone.");
        }
    }
}

class Chapter6 : Program.IChapter
{
    public void PlayChapter()
    {
        Console.WriteLine("\n--- Chapter 6: The Underground Cavern ---");
        Console.WriteLine("You descend into a dark, damp cavern. The air is thick, and the sound of dripping water echoes around you.");

        Console.WriteLine("As you explore, you encounter three pathways:");
        string[] pathways = { "Left path", "Middle path", "Right path" };

        for (int i = 0; i < pathways.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {pathways[i]}");
        }

        Console.WriteLine("Choose a pathway (1, 2, or 3):");
        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("The left path leads to a treasure chest guarded by a rock golem!");
                if (Program.player.Health > 0)
                {
                    Console.WriteLine("You defeat the golem and gain a rare gem.");
                    Program.player.Inventory.Add("Rare Gem");
                }
                break;

            case "2":
                Console.WriteLine("The middle path collapses! You barely escape but lose stamina.");
                Program.player.TakeDamage(10);
                Program.player.Stamina -= 10;
                break;

            case "3":
                Console.WriteLine("The right path leads to a shimmering pool of water that heals you.");
                Program.player.Health += 20;
                Console.WriteLine("You feel refreshed.");
                break;

            default:
                Console.WriteLine("You hesitated and stumbled, losing some health.");
                Program.player.TakeDamage(5);
                break;
        }
    }
}

class Chapter7 : Program.IChapter
{
    public void PlayChapter()
    {
        Console.WriteLine("\n--- Chapter 7: The Enchanted Glade ---");
        Console.WriteLine("You find yourself in a glade filled with glowing flowers and soothing melodies.");
        Console.WriteLine("A faerie queen appears and offers you a boon or a challenge.");

        Console.WriteLine("1. Accept the boon\n2. Take the challenge");
        string? choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("The faerie blesses you with enhanced agility.");
            Program.player.Agility += 5;
        }
        else if (choice == "2")
        {
            Console.WriteLine("The challenge is a duel of wits!");
            Console.WriteLine("Solve this riddle: The more of me you take, the more you leave behind. What am I?");
            string? answer = Console.ReadLine()?.ToLower();
            if (answer == "footsteps")
            {
                Console.WriteLine("You answered correctly and gain the faerie's respect. She grants you a magic amulet.");
                Program.player.Inventory.Add("Magic Amulet");
            }
            else
            {
                Console.WriteLine("You failed the riddle, and the faerie banishes you.");
                Program.player.TakeDamage(15);
            }
        }
        else
        {
            Console.WriteLine("You did nothing, and the opportunity vanished.");
        }
    }
}

class Chapter8 : Program.IChapter
{
    public void PlayChapter()
    {
        Console.WriteLine("\n--- Chapter 8: The Dragon's Lair ---");
        Console.WriteLine("You find a massive dragon guarding a hoard of treasure.");
        Console.WriteLine("Do you try to sneak past it, fight it, or negotiate? (sneak/fight/negotiate)");

        string? choice = Console.ReadLine()?.ToLower();
        if (choice == "sneak")
        {
            if (Program.player.Agility >= 15)
            {
                Console.WriteLine("You successfully sneak past the dragon and grab some treasure!");
                Program.player.Inventory.Add("Dragon's Gold");
            }
            else
            {
                Console.WriteLine("The dragon notices you and attacks!");
                Program.player.TakeDamage(20);
            }
        }
        else if (choice == "fight")
        {
            if (Program.player.Strength >= 15)
            {
                Console.WriteLine("You slay the dragon in a fierce battle!");
                Program.player.Inventory.Add("Dragon's Scale");
            }
            else
            {
                Console.WriteLine("The dragon overpowers you!");
                Program.player.TakeDamage(30);
            }
        }
        else if (choice == "negotiate")
        {
            if (Program.player.Wisdom >= 15)
            {
                Console.WriteLine("You cleverly negotiate with the dragon and leave unscathed with a trinket.");
                Program.player.Inventory.Add("Dragon's Trinket");
            }
            else
            {
                Console.WriteLine("The dragon refuses to listen and attacks!");
                Program.player.TakeDamage(25);
            }
        }
        else
        {
            Console.WriteLine("You hesitated and lost your chance to act.");
        }
    }
}

class Chapter9 : Program.IChapter
{
    public void PlayChapter()
    {
        Console.WriteLine("\n--- Chapter 9: The Cursed Village ---");
        Console.WriteLine("You enter a village where everyone seems frozen in time.");
        Console.WriteLine("You notice a cursed artifact glowing faintly in the town square.");

        Console.WriteLine("1. Destroy the artifact\n2. Attempt to use it\n3. Leave it alone");
        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("You destroy the artifact, breaking the curse!");
                Program.player.Wisdom += 5;
                break;
            case "2":
                Console.WriteLine("You attempt to use the artifact, but it drains your health.");
                Program.player.TakeDamage(15);
                break;
            case "3":
                Console.WriteLine("You leave it alone, and the village remains cursed.");
                break;
            default:
                Console.WriteLine("You do nothing, and the curse remains.");
                break;
        }
    }
}

class Chapter10 : Program.IChapter
{
    public void PlayChapter()
    {
        Console.WriteLine("\n--- Chapter 10: The Final Battle ---");
        Console.WriteLine("You face the dark sorcerer who has caused all the chaos.");
        Console.WriteLine("This is the final test of your strength, intelligence, and courage!");

        if (Program.player.Strength >= 20 || Program.player.Intelligence >= 20 || Program.player.Wisdom >= 20)
        {
            Console.WriteLine("Using your skills and resolve, you defeat the sorcerer and save the land!");
            Program.player.Inventory.Add("Sorcerer's Staff");
        }
        else
        {
            Console.WriteLine("The sorcerer overpowers you. Your journey ends here.");
            Program.player.TakeDamage(100);
        }
    }
}