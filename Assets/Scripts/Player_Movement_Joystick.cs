using UnityEngine;

public class Player_Movement_Joystick : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Joystick joystick;
    [SerializeField] private float mvspeed;



    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(joystick.Horizontal * mvspeed, _rigidbody.velocity.y, joystick.Vertical * mvspeed);
    }
    
}
