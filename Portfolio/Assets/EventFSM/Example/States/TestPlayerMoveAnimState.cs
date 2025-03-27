using EFSM.Event;
using EFSM.FSM;
using UnityEngine;

namespace EFSM.Example
{
    [CreateAssetMenu(menuName = "SO/EFSM/State/TestPlayerMoveAnimStats")]
    public class TestPlayerMoveAnimState : EFSMState
    {
        private Animator animator;
        private int walkHash;

        public override void Initialize(EFSMStateMachine owner)
        {
            base.Initialize(owner);
            animator = owner.GetComponent<Animator>();
            walkHash = Animator.StringToHash("Walk");
        }

        public override void EnterState()
        {
            animator.SetBool(walkHash, true);
        }

        public override void ExitState()
        {
            animator.SetBool(walkHash, false);
        }

        public override void HandleEvent(EFSMEvent evt)
        {
            if (evt is TestPlayerMoveEvent)
            {
                Owner.ChangeState(this);
            }
        }
    }
}
