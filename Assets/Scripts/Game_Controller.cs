using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game_Controller : MonoBehaviour
{
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI scoreText;

    public int score;
    public int highscore;

    public Score_Manager score_manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highscore = PlayerPrefs.GetInt("high_score");
        score = score_manager.score;

        highscoreText.text = "Highscore: " + highscore.ToString();
        scoreText.text = "Your Score: " + score.ToString();
      
    }

}
