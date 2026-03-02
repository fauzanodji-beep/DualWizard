using System.ComponentModel.Design;

Wizard wizard1 = new Wizard("jhonny", 20);
Wizard Wizard2 = new Wizard("Evil Jhonny", 10);

wizard1.ShowStats();
Wizard2.ShowStats();

wizard1.Attack(Wizard2);
Wizard2.Attack(wizard1);
wizard1.Attack(Wizard2);

Wizard2.Heal();
wizard1.Blast(Wizard2);

wizard1.ShowStats();
Wizard2.ShowStats();

public class Wizard
{
    public string Name;
    public int Mana;
    public int Damage;
    public int Gun;

    public Wizard(string name, int damage)
    {
        Name = name;
        Mana = 100;
        Damage = damage;
        Gun = 100;
    }

    public void Attack(Wizard Enemy)
    {
        Enemy.Mana -= Damage;

        if (Enemy.Mana < 0)
            Enemy.Mana = 0;
            
        Console.WriteLine($"{Name} Menyerang {Enemy.Name}");
        Console.WriteLine($"Sisa Mana {Enemy.Name} {Enemy.Mana}");
        Console.WriteLine();

    }

    public void Blast(Wizard Enemy)
    {
        Enemy.Mana -= Gun;

        if (Enemy.Mana < 0)
            Enemy.Mana = 0;

        Console.WriteLine($"{Name} Menembak {Enemy.Name}");
        Console.WriteLine($"Sisa Mana {Enemy.Name} {Enemy.Mana}");
        Console.WriteLine();

    }

    public void Heal()
    {
        
        if (Mana >= 100)
        {
            Console.WriteLine("Gagal Heal Energi sudah 100");
        }
        else
        {
            if (Mana > 95)
            {
                Mana = 100;
            }
            else
            {
                Mana += 10;
            }
           Console.WriteLine($"{Name} Melakukan Heal");
            Console.WriteLine($"Mana Sekarang: {Mana}");
            Console.WriteLine();
        }
        
            
    }

    public void ShowStats()
    {
        Console.WriteLine($"Nama Wizard : {Name}");
        Console.WriteLine($"Energi      : {Mana}");
        Console.WriteLine($"Damage      : {Damage}");
        Console.WriteLine("----------------------");
    }
}
    
