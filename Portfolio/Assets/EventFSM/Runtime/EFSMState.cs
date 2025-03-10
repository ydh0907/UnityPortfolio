using UnityEngine;

namespace EFSM
{
    [CreateAssetMenu(menuName = "SO/EFSM/State")]
    public class EFSMState : ScriptableObject
    {
        [SerializeField] private EFSMSubscriber owner;
        public virtual EFSMSubscriber Owner => owner;

        public virtual void HandleEvent(EFSMEvent evt)
        {

        }

        public virtual void EnterState() { }
        public virtual void UpdateState() { }
        public virtual void ExitState() { }
    }
}
