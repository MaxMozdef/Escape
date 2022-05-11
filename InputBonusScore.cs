using UnityEngine;

public class InputBonusScore : ScoreText
{
    
    protected void TapBonus()
    {
        if (Input.GetMouseButtonDown(0))
        {
            countCount++;
            if (countCount == 14)
            {
                gameScore++;
                countCount = 0;
            }
            ChangeCountScoreUI();
        }
    }
}
