using System.Collections;
using UnityEngine;

public class TimeBonusScore : InputBonusScore
{
    void Start()
    {
        StartCoroutine(TimeBonus());
    }

    private void Update()
    {
        TapBonus();
    }

    private IEnumerator TimeBonus()
    {
        yield return new WaitForSeconds(8.5f);
        gameScore++;
        StartCoroutine(TimeBonus());
    }
}
