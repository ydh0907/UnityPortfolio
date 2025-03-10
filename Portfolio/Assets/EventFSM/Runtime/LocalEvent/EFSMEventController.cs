using System.Collections.Generic;
using UnityEngine;

namespace EFSM.Event
{
    public class EFSMEventController : MonoBehaviour
    {
        [SerializeReference] public List<IEFSMEvent> eventTable = new();

        public void Publish<T>() where T : IEFSMEvent
        {
            foreach (IEFSMEvent evt in eventTable)
            {
                if (evt is T)
                {
                    evt.Publish();
                }
            }
        }

        public void Subscribe<T>(IEFSMEventHandler state) where T : IEFSMEvent
        {
            foreach (IEFSMEvent evt in eventTable)
            {
                if (evt is T)
                {
                    evt.Subscribe(state);
                }
            }
        }

        public void Unsubscribe<T>(IEFSMEventHandler state) where T : IEFSMEvent
        {
            foreach (IEFSMEvent evt in eventTable)
            {
                if (evt is T)
                {
                    evt.Unsubscribe(state);
                }
            }
        }
    }
}
