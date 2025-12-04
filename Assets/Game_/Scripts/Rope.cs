using UnityEngine;

public class Rope : MonoBehaviour
{
    public float movementtt = 5f;  
    public float frequency = 0.5f; 

    private Quaternion rope;

    void Start()
    {
        rope = transform.localRotation;
    }

    void Update()
    {
        float angle = Mathf.Sin(Time.time * frequency) * movementtt;
        transform.localRotation = rope * Quaternion.Euler(0f, 0f, angle);
    }
}
