using UnityEngine;

public class InputBonusScore : ScoreText
{
    
    protected void TapBonus()
    {
        if (Input.GetMouseButtonDown(0))
        {
            countCount++;
            if (countCount == 7)
            {
                gameScore++;
                countCount = 0;
            }

            ChangeCountScoreUI();
        }
    }
}
