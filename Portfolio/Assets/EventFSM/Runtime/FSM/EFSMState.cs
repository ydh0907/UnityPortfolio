using EFSM.Event;
using UnityEngine;

namespace EFSM.FSM
{
    [CreateAssetMenu(menuName = "SO/EFSM/State")]
    public class EFSMState : ScriptableObject
    {
        [SerializeField] private EFSMStateMachine owner;
        public virtual EFSMStateMachine Owner => owner;

        private bool actived = false;
        public bool Actived => actived;

        [SerializeField] private bool interruptible = true;
        public bool Interruptible => interruptible;

        public virtual void Initialize(EFSMStateMachine owner)
        {
            this.owner = owner;
            actived = false;
        }

        public virtual void EnterState() { actived = true; }
        public virtual void UpdateState() { }
        public virtual void ExitState() { actived = false; }
        public virtual void HandleEvent(EFSMEvent evt) { }
    }
}
