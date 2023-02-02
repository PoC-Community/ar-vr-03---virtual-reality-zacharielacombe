using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text text;

    public void addScore()
    {
        score += 5;
    }

    public int getScore()
    {
        return score;
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: ".ToString() + score.ToString();
    }
}
