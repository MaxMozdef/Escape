using TMPro;
using UnityEngine;


public class TotalScore : MonoBehaviour
{
    [SerializeField] protected static uint totalScor;
    [SerializeField] protected TextMeshProUGUI totalScoreViwe;
    [SerializeField] protected ScoreText ScoreText;
    [SerializeField] protected GameObject character, dntDesroyObject;

    private void Start()
    {
        DontDestroyOnLoad(dntDesroyObject);
        totalScoreLogic();
        totalScoreViwe.text = $"Total Score: {totalScor}";
    }
    

    private void totalScoreLogic()
    {
            totalScor += ScoreText.gameScore;
            Debug.Log("it work");
    }
}
