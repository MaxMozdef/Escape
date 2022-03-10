using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    [SerializeField] protected Rigidbody charRB;
    [SerializeField] private float jampPower;
    


    private void Update()
    {
        Jump();
    }
    private void Jump()
    {
        if (Input.GetMouseButtonDown(0))
        {
            charRB.AddForce(new Vector3(0, jampPower, 0) * Time.deltaTime);
        }
    }

}
