using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counterGamePointText;
    public static int gameScore;
    protected byte countCount;

    protected void ChangeCountScoreUI()
    {
        counterGamePointText.text = $"score: {gameScore}";
    }
}
