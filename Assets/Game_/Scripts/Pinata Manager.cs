using UnityEngine;

public class PinataManager : MonoBehaviour
{

    public Transform[] pinataspawns;

    public GameObject pinataprefab;

    int oldspawn = -1;
    
     void Update()
    {
        int newspawn = Random.Range(0, pinataspawns.Length);

        if (GameObject.FindGameObjectWithTag("Pinata") == null)
        {
            while (newspawn == oldspawn)
            {
                newspawn = Random.Range(0, pinataspawns.Length);
            }

            oldspawn = newspawn;

            Instantiate(pinataprefab, pinataspawns[newspawn].position, pinataspawns[newspawn].rotation);
        }
    }
}
