using UnityEngine;
using TMPro;
using StarterAssets;

public class ScoreManager : MonoBehaviour
{

    UltimateFirstPersonController player;

    public TextMeshProUGUI scoredisplay;

    public GameObject wintext;

    public int score;

    void Awake()
    {

        wintext.SetActive(false);
        score = 0;

        scoredisplay.text = $"{score} / 5";
    }

    public void addscore()
    {
            score += 1;

            scoredisplay.text = $"{score} / 5";
    }

    void Update()
    {
        if (score >= 5)
        {

            wintext.SetActive(true);
            player.MoveSpeed = 0f;
            player.SprintSpeed = 0f;


        }
        
    }
}
