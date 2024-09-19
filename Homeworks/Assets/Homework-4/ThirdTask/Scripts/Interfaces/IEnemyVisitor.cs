namespace Homework4
{
    public interface IEnemyVisitor
    {
        void Visit(Orc orc);
        void Visit(Human human);
        void Visit(Elf elf);
        void Visit(Robot robot);
    }
}
