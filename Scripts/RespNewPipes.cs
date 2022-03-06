using UnityEngine;

public class RespNewPipes : MonoBehaviour
{
    [SerializeField] private GameObject newPipe, respPointPipe, pointRespOne, pointRespTwo;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "TriggerForRespPipes")
        {
            Instantiate(newPipe, respPointPipe.transform.position, Quaternion.Euler(0, 90, 0));
            Debug.Log("good");
        }
    }

}
