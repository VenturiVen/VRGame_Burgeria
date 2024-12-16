using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    // reused my code from my other project for this
    // other project: https://github.com/VenturiVen/3D_FPS

    public GameObject textmeshpro_score;

    public int score;

    TextMeshProUGUI textmeshpro_score_text;

    // Start is called before the first frame update
    void Start()
    {
        textmeshpro_score_text = textmeshpro_score.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void ChangeText(int score)
    {
        textmeshpro_score_text.text = "Burgers: " + score.ToString("00");
    }
}
