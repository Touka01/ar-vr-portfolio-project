using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Actions/Pause Game")]
public class ActionPauseGame : ScriptableObject
{
    [SerializeField]
    private BoolEvent pauzeEvent;

    public void Execute(bool state)
    {
        pauzeEvent.Invoke(state);
    }

}