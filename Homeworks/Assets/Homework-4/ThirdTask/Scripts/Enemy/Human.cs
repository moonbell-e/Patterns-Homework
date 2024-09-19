namespace Homework4
{
    public class Human : Enemy
    {
        public Human()
        {
            Weight = 5;
        }
        
        public override void Accept(IEnemyVisitor visiter) => visiter.Visit(this);
    }
}
