using Homework_3.Interfaces;

namespace Homework_3
{
    public class PlayerLevel: ILevel
    {
        public int CurrentLevel { get; private set; }

        private readonly PlayerMediator _mediator;
        
        public PlayerLevel(PlayerMediator mediator)
        {
            CurrentLevel = 1;
            _mediator = mediator;
            
            _mediator.OnLevelChanged(CurrentLevel);
        }
        
        public void AddLevel()
        {
            CurrentLevel++;
            _mediator.OnLevelChanged(CurrentLevel);
        }
        
        public void ResetLevel()
        {
            CurrentLevel = 1;
            _mediator.OnLevelChanged(CurrentLevel);
        }
    }
}