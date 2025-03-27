using EFSM.Event;
using System.Collections.Generic;
using UnityEngine;

namespace EFSM.Example
{
    public class TestPlayer : EFSMEventController
    {
        [SerializeField] private InputSO input;

        private List<TestPlayerMoveEvent> moveEvt = new();

        private void Awake()
        {
            input.onAttack += HandleAttack;
            input.onMove += HandleMove;
        }

        private void OnDestroy()
        {
            input.onAttack -= HandleAttack;
            input.onMove -= HandleMove;
        }

        private void HandleMove(Vector2 dir)
        {
            moveEvt.Clear();
            GetEvent(moveEvt);

            Vector2 ndir = dir.normalized;
            for (int i = 0; i < moveEvt.Count; i++)
            {
                moveEvt[i].normalDirection = ndir;
                moveEvt[i].Publish();
            }
        }

        private void HandleAttack()
        {
            Publish<TestPlayerAttackEvent>();
        }
    }
}
