using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text TextScore;
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0f;
    }

    // Update is called once per frame
    public void increaseScore()
    {
        score++;
    }

    // Update is called once per frame
    void Update()
    {
        TextScore.text = "COINS: " + score.ToString();
    }
}
