using System.Collections.Generic;
using UnityEngine;

public class CalibrateRespDO : MonoBehaviour
{
    [SerializeField] protected List<GameObject> dangerousObjectsList = new List<GameObject>();
    void Update()
    {
        CalibratYVectorResp();
    }
    private void CalibratYVectorResp()
    {
        if (dangerousObjectsList[(Random.Range(0, 4))].transform.position.y > 21.6f)
        {
            dangerousObjectsList[(Random.Range(0, 4))].transform.position = new Vector3(transform.position.x, 21f, transform.position.z);
        }
    }
}
