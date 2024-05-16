using System.Xml.Linq;

namespace _05._Dragon_Army
{
    internal class Program
    {
        class Dragon
        {
            public Dragon(string dragonColor, string dragonName, double dragonDamage, double dragonHealth,
                double dragonArmor)
            {
                DragonColor = dragonColor;
                DragonName = dragonName;
                DragonDamage = dragonDamage;
                DragonHealth = dragonHealth;
                DragonArmor = dragonArmor;
            }

            public string DragonColor { get; set; }
            public string DragonName { get; set; }
            public double DragonDamage { get; set; }
            public double DragonHealth { get; set; }
            public double DragonArmor { get; set; }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, Dictionary<string, List<double>>>();
            double defaultDamage = 45;
            double defaultHealth = 250;
            double defaultArmor = 10;

            double newDamage;
            double newHealth;
            double newArmor;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string dragonColor = input[0];
                string dragonName = input[1];
                double damage = double.TryParse(input[2], out newDamage) ? newDamage : defaultDamage;
                double health = double.TryParse(input[3], out newDamage) ? newDamage : defaultHealth;
                double armor = double.TryParse(input[4], out newDamage) ? newDamage : defaultArmor;



                Dragon newDragon = new Dragon(dragonColor, dragonName, damage, health, armor);
                if (!dragons.ContainsKey(dragonColor))
                {
                    dragons.Add(dragonColor, new Dictionary<string, List<double>>());
                }

                if (!dragons[dragonColor].ContainsKey(dragonName))
                {
                    dragons[dragonColor].Add(dragonName, new List<double>());
                    dragons[dragonColor][dragonName].Add(damage);
                    dragons[dragonColor][dragonName].Add(health);
                    dragons[dragonColor][dragonName].Add(armor);
                }
                else
                {
                    dragons[dragonColor][dragonName].Clear();
                    dragons[dragonColor][dragonName].Add(damage);
                    dragons[dragonColor][dragonName].Add(health);
                    dragons[dragonColor][dragonName].Add(armor);
                }

            }


            foreach (var type in dragons)
            {
                double averageDamage = 0;
                double averageHealth = 0;
                double averageArmor = 0;
                double count = 0;

                foreach (var dragon in type.Value)
                {
                    List<double> dragonStats = dragon.Value;
                    averageDamage += dragonStats[0];
                    averageHealth += dragonStats[1];
                    averageArmor += dragonStats[2];
                    count++;
                }

                Console.WriteLine(
                    $"{type.Key}::({averageDamage / count:F2}/{averageHealth / count:F2}/{averageArmor / count:F2})");

                foreach (var dragon in type.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine(
                        $"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }

        }

    }
}

