using System.Collections.Generic;
using UnityEngine;

namespace EFSM.FSM
{
    public class EFSMStateMachine : MonoBehaviour
    {
        public List<EFSMState> states = new();
        public EFSMState initState;

        private EFSMState currentState;

        private void Awake()
        {
            for (int i = 0; i < states.Count; i++)
                states[i].Initialize(this);
            if (initState != null)
                ChangeState(initState);
        }

        private void Update()
        {
            currentState?.UpdateState();
        }

        public void ChangeState(EFSMState state)
        {
            currentState?.ExitState();
            currentState = state;
            currentState?.EnterState();
        }

        public void Stop()
        {
            currentState?.ExitState();
            currentState = null;
        }
    }
}
