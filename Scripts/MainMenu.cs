using UnityEngine;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject startButton, exitButton, carackterRobberClone, carackterRobber, tapToGo;
    [SerializeField] private TextMeshProUGUI totalScoreViwe, currentAccount;
    [SerializeField] private ScoreText textScore;
    


    void Start()
    {
        StartConfiguration();
    }
    
    private void StartConfiguration()
    {
        Time.timeScale = 0;
        startButton.SetActive(true);
        exitButton.SetActive(true);
        carackterRobber.SetActive(false);
        carackterRobberClone.SetActive(true);
        tapToGo.SetActive(false);
    }
    public void StartGame()
    {
        Time.timeScale = 0;
        startButton.SetActive(false);
        exitButton.SetActive(false);
        carackterRobber.SetActive(true);
        carackterRobberClone.SetActive(false);
        tapToGo.SetActive(true);
        totalScoreViwe.gameObject.SetActive(false);
        ScoreText.gameScore = 0;
    }
    public void Go()
    {
        Time.timeScale = 1;
        tapToGo.SetActive(false);
        currentAccount.gameObject.SetActive(true);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
