using TMPro;
using UnityEngine;

public class TotalScore : MonoBehaviour
{
    public int totalScor;
    [SerializeField] protected TextMeshProUGUI totalScoreViwe;
    [SerializeField] protected ScoreText ScoreText;
    

    private void Start()
    {
        totalScoreLogic();
        totalScoreViwe.text = $"Total Score: {totalScor}";
    }

    
    public void totalScoreLogic()
    {
        totalScor = PlayerPrefs.GetInt("totalScoreGame");
        totalScor += ScoreText.gameScore;
        PlayerPrefs.SetInt("totalScoreGame", totalScor);
    }
}
