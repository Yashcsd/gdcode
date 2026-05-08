using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI text;
    int score;

    public void Add()
    {
        score++;
        text.text = "Score : " + score;
    }
}