using System.Collections.Generic;
using UnityEngine;

namespace EFSM
{
    public class EFSMController : MonoBehaviour
    {
        public List<EFSMEvent> eventTable = new();

        private void Awake()
        {
            for (int i = 0; i < eventTable.Count; i++)
            {
                eventTable[i] = Instantiate(eventTable[i]);
            }
        }

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
    }
}
