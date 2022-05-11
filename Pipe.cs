using UnityEngine;
using UnityEngine.SceneManagement;

public class Pipe : MonoBehaviour
{
    [SerializeField] private GameObject charakterRobber;
    [SerializeField] private TotalScore scoreTotal;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pipe" || collision.gameObject.tag == "DangerousObjeckts")
        {
            SceneManager.LoadScene(0);
        }
    }
    
}
