using UnityEngine;

public class cursor : MonoBehaviour
{
     public Transform target;

    void Update()
    {

        target = GameObject.FindWithTag("Pinata").transform;
        transform.LookAt(target.position);
    }

}

