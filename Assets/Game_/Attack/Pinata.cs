using Unity.VisualScripting;
using UnityEngine;

public class Pinata : MonoBehaviour
{
    public Transform other;

    void Update()
    {
        if (other)
        {
            float distancetoplayer = Vector3.Distance(other.position, transform.position);

            if (distancetoplayer < 2.5f)
            {
                Destroy(gameObject);
                

                Debug.Log("punch");
            }
        }

        
    }

}
