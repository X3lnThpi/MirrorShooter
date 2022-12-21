using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 0f;
    public float maxSpeed = 10f;
    public float acceleration = 1f;
    public float deceleration = 1f;
    public float jumpStrength = 10f;
    public float sensitivity;

    private ICommand currentCommand;

    void Update()
    {
        if (currentCommand != null)
        {
            currentCommand.Execute(this);
        }

        // Handle character movement
        if (Input.GetKey(KeyCode.W))
        {
            Run();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Walk();
        }
        else
        {
            Stop();
        }

        

        // Handle character rotation
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, mouseX);

        transform.Rotate(Vector3.up, mouseX * sensitivity);
    }

    public void SetCommand(ICommand command)
    {
        currentCommand = command;
    }

    public void Walk()
    {
        if (speed < maxSpeed)
        {
            speed += acceleration;
        }
    }

    public void Run()
    {
        if (speed < maxSpeed)
        {
            speed += acceleration * 2;
        }
    }

    public void Stop()
    {
        if (speed > 0)
        {
            speed -= deceleration;
        }
    }

    public void Jump()
    {
        // Jumping code goes here
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (rigidbody.velocity.y == 0)
        {
            rigidbody.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
        }
    }
}
