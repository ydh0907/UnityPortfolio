using System.Collections.Generic;
using UnityEngine;

namespace EFSM.Event
{
    public class EFSMEvent : ScriptableObject, IEFSMEvent
    {
        [SerializeReference] public List<IEFSMEventHandler> subscribers;

        public virtual void Publish()
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.HandleEvent(this);
            }
        }

        public virtual void Subscribe(IEFSMEventHandler handler)
        {
            subscribers.Add(handler);
        }

        public virtual void Unsubscribe(IEFSMEventHandler handler)
        {
            subscribers.Remove(handler);
        }
    }
}
