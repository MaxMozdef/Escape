using System.Collections.Generic;
using UnityEngine;

public class RespDangerousObject : MonoBehaviour
{
    [SerializeField] private GameObject fogRobber;
    [SerializeField] protected List<GameObject> dangerousObjectsList = new List<GameObject>();
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "RespDOOne")
        {
            Instantiate(dangerousObjectsList[(Random.Range(0, 4))], fogRobber.transform.position, Quaternion.Euler(0, 180, 0));
            
        }
    }
}
