using EFSM.Event;
using UnityEngine;

namespace EFSM.Example
{
    [CreateAssetMenu(menuName = "SO/EFSM/Event/TestPlayerMoveEvent")]
    public class TestPlayerMoveEvent : EFSMEvent
    {
        public Vector2 normalDirection;
    }
}
