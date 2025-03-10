using System.Collections.Generic;
using UnityEngine;

namespace EFSM
{
    public class EFSMEvent : ScriptableObject
    {
        [SerializeField] private List<EFSMState> subs;

        public virtual void Subscribe(EFSMState state) => subs.Add(state);
        public virtual void Unsubscribe(EFSMState state) => subs.Remove(state);

        public virtual void Publish()
        {
            foreach (var sub in subs)
            {
                sub.HandleEvent(this);
            }
        }
    }
}
