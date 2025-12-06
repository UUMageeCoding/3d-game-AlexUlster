using UnityEngine;
using StarterAssets;
using UnityEngine.InputSystem;

public class Ladder : MonoBehaviour
{
    public GameObject player;
    public float climbSpeed = 3f;

    public UltimateFirstPersonController controller;
    public CharacterController cc;

    bool onLadder = false;

    void Awake()
    {
        controller = player.GetComponent<UltimateFirstPersonController>();
        cc = player.GetComponent<CharacterController>();
    }

    void OnTriggerStay(Collider other)
    {
        onLadder = true;
        controller.Gravity = 0f;
    }

    void OnTriggerExit(Collider other)
    {
        onLadder = false;
        controller.Gravity = -17f;
    }

    void Update()
    {
        if (onLadder && Keyboard.current.wKey.isPressed)
        {
            Debug.Log("going up");
            cc.Move(Vector3.up * climbSpeed * Time.deltaTime);
        }
    }
}
