using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FiniteStateThread<E, O> where E : Enum where O : MonoBehaviour
{
    private Dictionary<E, FiniteState<E, O>> states;

    public FiniteStateThread(O obj)
    {
        foreach (var state in Enum.GetValues(typeof(E)))
        {
            
        }
    }

    public void ChangeState(E state)
    {

    }
}
