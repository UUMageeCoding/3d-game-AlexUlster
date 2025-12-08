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

    public float time = 0f;

    public int score;

    public int HIGHESTSCORE;


    void Awake()
    {
        
        HIGHESTSCORE = PlayerPrefs.GetInt("high score bruh", 0);
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
        if (score > HIGHESTSCORE)
{
        PlayerPrefs.SetInt("high score bruh", score);
        PlayerPrefs.Save();
}
        time += Time.deltaTime;

        timer.text = $"{time:F2}";

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
