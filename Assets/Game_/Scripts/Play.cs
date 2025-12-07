using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public Animator fadeout;

    public void ButtonPress()
    {
        Fadeout();
    }

    public void Fadeout()
    {
        fadeout.Play("FadeOut");  
        Invoke("sceneswitch", 3f);
    }    

    public void sceneswitch()
    {
        SceneManager.LoadScene(1);
    }    
}
