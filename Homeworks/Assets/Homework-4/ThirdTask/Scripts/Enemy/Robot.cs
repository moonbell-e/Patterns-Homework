namespace Homework4
{
    public class Robot : Enemy
    {
        public Robot()
        {
            Weight = 7;
        }

        public override void Accept(IEnemyVisitor visiter) => visiter.Visit(this);
    }
}