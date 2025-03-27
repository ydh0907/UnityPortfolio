using EFSM.Event;
using System.Collections.Generic;
using UnityEngine;

namespace EFSM.Example
{
    [CreateAssetMenu(menuName = "SO/EFSM/Event/TestPlayerAnimEventHandle")]
    public class TestPlayerAnimEventHandle : EFSMEventController
    {
        private List<TestPlayerAnimationTriggerEvent> targetEvt = new();

        public void OnAttackEnd()
        {
            targetEvt.Clear();
            GetEvent(targetEvt);
            targetEvt.ForEach(evt =>
            {
                evt.trigger = TestPlayerAnimationTrigger.AttackEnd;
                evt.Publish();
            });
        }
    }
}
