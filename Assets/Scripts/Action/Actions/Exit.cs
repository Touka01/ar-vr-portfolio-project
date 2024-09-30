using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void ExitApplication()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;  // Exit play mode in the editor
        #else
        Application.Quit();  // Exit the built game
        #endif
    }
}