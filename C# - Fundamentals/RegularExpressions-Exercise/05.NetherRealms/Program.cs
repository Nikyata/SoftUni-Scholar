using System.Text;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    internal class Program
    {
        class Demon
        {
            public Demon(string name, double health, double damage)
            {
                Name = name;
                Health = health;
                Damage = damage;
            }

            public string Name  { get; set; }
            public double Health  { get; set; }
            public double Damage  { get; set; }

            public override string ToString()
            {
                return $"{Name} - {Health} health, {Damage:f2} damage";
            }
        }
        static void Main()
        {
            string input = Console.ReadLine();
            string[] names = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string healthPattern = @"[^0-9\*\/\+\-\.]";
            double hp = 0;
            double damage = 0;
            List<Demon> demons = new List<Demon>();
            for (int i = 0; i < names.Length; i++)
            {
                StringBuilder demonHp = new StringBuilder();
                foreach(Match m in Regex.Matches(names[i], healthPattern))
                {
                    demonHp.Append(m.Value);
                }

                for (int j = 0; j < demonHp.Length; j++)
                {
                    hp += (int)demonHp[j];
                }
                string dmgPattern = @"(?<digits>[+|-]*\d+(?:\.\d+)?)";
                string multiplyPattern = @"[\*\/]";


                foreach (Match m in Regex.Matches(names[i], dmgPattern))
                {
                    damage += double.Parse(m.Groups["digits"].Value);

                }

                var matches = Regex.Matches(names[i], multiplyPattern);
                foreach (Match match in matches)
                {
                    switch (match.Value)
                    {
                        case "/":
                            damage /= 2;
                            break;
                        case "*":
                            damage *= 2;
                            break;
                    }
                }
                Demon newDemon = new Demon(names[i], hp, damage);
                demons.Add(newDemon);
                hp = 0;
                damage = 0;
            }

            foreach (var demon in demons.OrderBy(x=>x.Name))
            {
                Console.WriteLine(demon);
            }


        }
    }
}
