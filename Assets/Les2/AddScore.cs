using UnityEngine;
using TMPro;

public class AddScore : MonoBehaviour
{
    private int score = 0;
    private TextMeshProUGUI text; 

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>(); 
        text.text = "Score: " + score;

        ActionManager.OnAddScore += AddScoreMethod;
    }

    void OnDestroy()
    {
        ActionManager.OnAddScore -= AddScoreMethod;
    }

    private void AddScoreMethod()
    {
        score++;
        text.text = "Score: " + score;
    }
}
