using UnityEngine;
using Unity.Collections;
using System.Collections;
using StarterAssets;

public class GO : MonoBehaviour
{
    public GameObject three;
    public GameObject two;
    public GameObject one;
    public GameObject go;

    public GameObject player;

    public UltimateFirstPersonController controller;

    private void Awake()
    {
        controller = player.GetComponent<UltimateFirstPersonController>();

        controller.enabled = false;
        
        three.gameObject.SetActive(true);
        two.gameObject.SetActive(false);
        one.gameObject.SetActive(false);
        go.SetActive(false);
    }

    void Start()
    {
        StartCoroutine(countdown());
    }

    public IEnumerator countdown()
    {
        yield return new WaitForSeconds(.6f);

        three.gameObject.SetActive(false);
        two.gameObject.SetActive(true);

        yield return new WaitForSeconds(.8f);

        two.gameObject.SetActive(false);
        one.gameObject.SetActive(true);

        yield return new WaitForSeconds(.9f);

        one.gameObject.SetActive(false);
        go.gameObject.SetActive(true);
        controller.enabled = true;

        yield return new WaitForSeconds(.9f);

        go.SetActive(false);

        
    }

}
