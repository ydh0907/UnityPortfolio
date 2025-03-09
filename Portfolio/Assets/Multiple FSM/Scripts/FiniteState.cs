using System;
using UnityEngine;

public abstract class FiniteState<E, O> where E : Enum where O : MonoBehaviour
{
    protected O owner;
    protected FiniteStateThread<E, O> stateThread;
    protected MultipleFiniteStateMachine stateMachine;

    public FiniteState(O owner)
    {
        this.owner = owner;
    }

    public void EnterState() { }
    public void UpdateState() { }
    public void ExitState() { }
    public void HandleEvent(StateEvent evt) { }
}
