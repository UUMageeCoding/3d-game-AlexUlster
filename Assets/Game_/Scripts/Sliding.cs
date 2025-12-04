using StarterAssets;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class Sliding : MonoBehaviour
{
    public Transform orientation;
    public Transform player;
    private Rigidbody playerrb;

    private UltimateFirstPersonController controller;

    public float SlideTime;

    public float SlideForce;

    public float slideMaxtime;

    public float slideyscale;
    public float startyscale;

    public KeyCode slidekey = KeyCode.LeftControl;

    private float horizontalinput;
    private float verticalinput;

    private bool sliding;

    void Start()
    {
        playerrb = GetComponent<Rigidbody>();
        controller = GetComponent<UltimateFirstPersonController>();

        startyscale = player.localScale.y;
    }

    void Update()
    {
        horizontalinput = Input.GetAxisRaw("Horizontal");
        verticalinput = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(slidekey) && (horizontalinput != 0 || verticalinput != 0))
        {
            StartSlide();
        }
        if (Input.GetKeyUp(slidekey) && sliding)
        {
            StopSlide();
        }
    }

    void FixedUpdate()
    {
        if(sliding)
        {
            SlidingMovement();
        }
    }

    private void StartSlide()
    {
        sliding = true;

        player.localScale = new Vector3(player.localScale.x, slideyscale, player.localScale.z);

        playerrb.AddForce(Vector3.down *5f, ForceMode.Impulse);

        SlideTime = slideMaxtime;
    }

     private void SlidingMovement()
    {
        Vector3 inputDirection = orientation.forward * verticalinput + orientation.right * horizontalinput;

        playerrb.AddForce(inputDirection.normalized * SlideForce, ForceMode.Force);

        SlideTime -= Time.deltaTime;

        if (SlideTime <= 0)
        {
            StopSlide();
        }
    }

     private void StopSlide()
    {
        sliding = false;

        player.localScale = new Vector3(player.localScale.x, startyscale, player.localScale.z);
    }
}
