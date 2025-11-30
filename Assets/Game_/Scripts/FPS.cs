using UnityEngine;

public class FPSCap : MonoBehaviour
{
    [SerializeField] private int frameRate = 60;

    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = frameRate;
    }
}
