using UnityEngine;
using TMPro;
using StarterAssets;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoredisplay;

    public GameObject finishtext;

    public AudioSource sourceaudio;

    public UltimateFirstPersonController controller;

    public AudioClip FINISH;

    public TextMeshProUGUI timer;

    public Animator fadeout;

    public int score;

    void Awake()
    {

        finishtext.SetActive(false);
        score = 0;
        scoredisplay.text = $"Score: {score}";
    }

    public void addscore()
    {
            score += 1;
            scoredisplay.text = $"Score: {score}";
    }

    void Update()
    {
        timer.text = $"{Time.time:F2}";

        if (timer.text == "60.00")
        {
            fadeout.Play("FadeOut");
            controller.attackDamage = 0;
            finishtext.SetActive(true);
            sourceaudio.PlayOneShot(FINISH);

            Invoke("sceneswitcher", 4);

        }
    }

    public void sceneswitcher()
    {
        SceneManager.LoadScene(0);
    }
}
