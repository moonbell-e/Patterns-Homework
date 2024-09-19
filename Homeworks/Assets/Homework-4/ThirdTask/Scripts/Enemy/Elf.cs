namespace Homework4
{
    public class Elf : Enemy
    {
        public Elf()
        {
            Weight = 3;
        }

        public override void Accept(IEnemyVisitor visiter) => visiter.Visit(this);
    }
}