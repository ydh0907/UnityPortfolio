using EFSM.Event;
using UnityEngine;

namespace EFSM.Example
{
    public enum TestPlayerAnimationTrigger
    {
        AttackEnd = 0,
    }

    [CreateAssetMenu(menuName = "SO/EFSM/Event/TestPlayerAnimationTriggerEvent")]
    public class TestPlayerAnimationTriggerEvent : EFSMEvent
    {
        public TestPlayerAnimationTrigger trigger;
    }
}
