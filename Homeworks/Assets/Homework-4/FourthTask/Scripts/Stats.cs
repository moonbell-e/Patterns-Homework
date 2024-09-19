namespace Homework_4
{
    public class Stats
    {
        private int Strength { get; set; }
        private int Intelligence { get; set; }
        private int Agility { get; set; }
    
        public Stats(int strength, int intelligence, int agility)
        {
            Strength = strength;
            Intelligence = intelligence;
            Agility = agility;
        }
        
        public override string ToString()
        {
            return $"Strength: {Strength}, Intelligence: {Intelligence}, Agility: {Agility}";
        }
    
        public void AddStats(Stats stats)
        {
            Strength += stats.Strength;
            Intelligence += stats.Intelligence;
            Agility += stats.Agility;
        }
    
        public void MultiplyStats(Stats stats)
        {
            Strength *= stats.Strength;
            Intelligence *= stats.Intelligence;
            Agility *= stats.Agility;
        }
    }
}
