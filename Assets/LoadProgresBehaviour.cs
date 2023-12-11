using UnityEngine;

public class LoadProgresBehaviour : MonoBehaviour
{
    public void ShowProgress(float progress)
    {
        Debug.Log($"{Time.realtimeSinceStartup}: {progress}");
    }
}
