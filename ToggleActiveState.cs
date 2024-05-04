using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class ToggleActiveState
{
    static ToggleActiveState()
    {
        SceneView.duringSceneGui += view =>
        {
            if (Event.current != null && Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.C)
            {
                foreach (var gameObject in Selection.gameObjects)
                {
                    gameObject.SetActive(!gameObject.activeSelf);
                }
            }
        };
    }
}
