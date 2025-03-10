using EFSM.Event;
using System.Collections.Generic;
using UnityEngine;

namespace EFSM.FSM
{
    [CreateAssetMenu(menuName = "SO/EFSM/State")]
    public class EFSMState : ScriptableObject, IEFSMEventHandler
    {
        [SerializeField] private EFSMStateMachine owner;
        public virtual EFSMStateMachine Owner => owner;

        public virtual void Initialize(EFSMStateMachine owner)
        {
            this.owner = owner;
        }

        public virtual void EnterState() { }
        public virtual void UpdateState() { }
        public virtual void ExitState() { }
        public virtual void HandleEvent(IEFSMEvent evt) { }
    }
}
