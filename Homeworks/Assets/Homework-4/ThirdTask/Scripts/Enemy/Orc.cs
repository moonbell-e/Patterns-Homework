namespace Homework4
{
    public class Orc: Enemy
    {
        public Orc()
        {
            Weight = 10;
        }
        
        public override void Accept(IEnemyVisitor visiter) => visiter.Visit(this);
    }
}
