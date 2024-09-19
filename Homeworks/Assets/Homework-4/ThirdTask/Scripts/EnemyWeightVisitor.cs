
namespace Homework4
{
    public class EnemyWeightVisitor : IEnemyVisitor
    {
        public float TotalWeight { get; private set; }
        public void Visit(Orc orc)
        {
            TotalWeight += orc.Weight;
        }

        public void Visit(Human human)
        {
            TotalWeight += human.Weight;
        }

        public void Visit(Elf elf)
        {
            TotalWeight += elf.Weight;
        }

        public void Visit(Robot robot)
        {
            TotalWeight += robot.Weight;
        }
    }
}
