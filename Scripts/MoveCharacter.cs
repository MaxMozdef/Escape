using UnityEngine;

public class MoveCharacter : CharacterJump
{
    [SerializeField] private float speedMovement;

    
    void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        charRB.transform.Translate(0, 0, speedMovement * Time.deltaTime);
    }
}
