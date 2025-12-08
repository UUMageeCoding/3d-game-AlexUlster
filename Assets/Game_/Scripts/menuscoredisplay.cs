using UnityEngine;
using TMPro;

public class menuscoredisplay : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;

    
    void Start()
    {

        Cursor.visible = true;
        
        int highscore = PlayerPrefs.GetInt("high score bruh", 0);

        highScoreText.text = $"High Score: {highscore} ";
    }
}
