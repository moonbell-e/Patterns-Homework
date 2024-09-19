using UnityEngine;

namespace Homework_4
{
    public class Character : MonoBehaviour
    {
        private IStatProvider _statProvider;

        public void Initialize(IStatProvider statProvider)
        {
            _statProvider = statProvider;
        }
        
        public Stats GetStats()
        {
            return _statProvider.GetStats();
        }
    }
}
