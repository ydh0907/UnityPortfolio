using EFSM.Event;
using EFSM.FSM;
using UnityEngine;

namespace EFSM.Example
{
    [CreateAssetMenu(menuName = "SO/EFSM/State/TestPlayerIdleAnimState")]
    public class TestPlayerIdleAnimState : EFSMState
    {
        public override void HandleEvent(EFSMEvent evt)
        {
            if (evt is TestPlayerStopEvent)
            {
                Owner.ChangeState(this);
            }
        }
    }
}
