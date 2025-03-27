using EFSM.Event;
using EFSM.FSM;
using UnityEngine;

namespace EFSM.Example
{
    [CreateAssetMenu(menuName = "SO/EFSM/State/TestPlayerAttackAnimState")]
    public class TestPlayerAttackAnimState : EFSMState
    {
        private Animator animator;
        private int attackHash;

        public override void Initialize(EFSMStateMachine owner)
        {
            base.Initialize(owner);
            animator = owner.GetComponent<Animator>();
            attackHash = Animator.StringToHash("Attack");
        }

        public override void EnterState()
        {
            animator.SetTrigger(attackHash);
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
