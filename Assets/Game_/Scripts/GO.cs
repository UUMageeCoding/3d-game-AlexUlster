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

        controller.MoveSpeed = 0;
        controller.SprintSpeed = 0;
        
        three.SetActive(true);
        two.SetActive(false);
        one.SetActive(false);
        go.SetActive(false);
    }

    void Start()
    {
        StartCoroutine(countdown());
    }

    public IEnumerator countdown()
    {
        yield return new WaitForSeconds(.6f);

        three.SetActive(false);
        two.SetActive(true);

        yield return new WaitForSeconds(.8f);

        two.SetActive(false);
        one.SetActive(true);

        yield return new WaitForSeconds(.9f);

        one.SetActive(false);
        go.SetActive(true);
        controller.MoveSpeed = 7;
        controller.SprintSpeed = 7;

        yield return new WaitForSeconds(.9f);

        go.SetActive(false);

        
    }

}
