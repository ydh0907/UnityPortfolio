using EFSM.FSM;
using System.Collections.Generic;
using UnityEngine;

namespace EFSM.Event
{
    public class EFSMEventController : MonoBehaviour
    {
        public List<EFSMEvent> eventTable = new();

        public void Publish<T>() where T : EFSMEvent
        {
            foreach (EFSMEvent evt in eventTable)
            {
                if (evt is T)
                {
                    evt.Publish();
                }
            }
        }

        public void Subscribe<T>(EFSMState state) where T : EFSMEvent
        {
            foreach (EFSMEvent evt in eventTable)
            {
                if (evt is T)
                {
                    evt.Subscribe(state);
                }
            }
        }

        public void Unsubscribe<T>(EFSMState state) where T : EFSMEvent
        {
            foreach (EFSMEvent evt in eventTable)
            {
                if (evt is T)
                {
                    evt.Unsubscribe(state);
                }
            }
        }
    }
}
