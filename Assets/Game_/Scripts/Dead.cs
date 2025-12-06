using StarterAssets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{

    public GameObject Arms;

    public GameObject player;

   
    void OnTriggerEnter(Collider other)
    {

        var cc = GameObject.FindWithTag("Player").GetComponent<CharacterController>();

        var controller = GameObject.FindWithTag("Player").GetComponent<UltimateFirstPersonController>();

        controller.Gravity = 0f;
        controller.MoveSpeed = 0f;
        controller.SprintSpeed = 0f;
        controller.JumpHeight = 0f;


       
        cc.enabled = false;

        Destroy(Arms);

        

         Invoke("sceneswitch", 3f);
    }

    public void sceneswitch()
    {
        SceneManager.LoadScene("Environment");
    }

}
