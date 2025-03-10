using EFSM.FSM;
using System.Collections.Generic;
using UnityEngine;

namespace EFSM.Event
{
    public class EFSMEvent : ScriptableObject
    {
        public List<EFSMState> subscribers;

        public virtual void Publish()
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.HandleEvent(this);
            }
        }

        public virtual void Subscribe(EFSMState handler)
        {
            subscribers.Add(handler);
        }

        public virtual void Unsubscribe(EFSMState handler)
        {
            subscribers.Remove(handler);
        }
    }
}
