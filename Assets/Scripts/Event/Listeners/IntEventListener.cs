using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class IntEventListener : ScriptableEventListener<int>
{
    [SerializeField]
    protected IntEvent eventObject;

    [SerializeField]
    protected UnityEventInt eventAction;

    protected override ScriptableEvent<int> ScriptableEvent
    {
        get
        {
            return eventObject;
        }
    }

    protected override UnityEvent<int> Action
    {
        get
        {
            return eventAction;
        }
    }
}