using UnityEngine;

public class RotateDangerousObject : MonoBehaviour
{
    [SerializeField] private GameObject dangerousObj;
    [SerializeField] private float speedRoration;

    private void FixedUpdate()
    {
        RotateDO();
    }

    private void RotateDO()
    {
        dangerousObj.transform.Rotate(0, speedRoration * Time.deltaTime, ((float)Space.Self));
    }
}
