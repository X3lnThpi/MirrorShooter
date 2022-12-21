using UnityEngine;

public class Enemy : MonoBehaviour
{
    public CharacterMovement characterMovement;
    public RocketPropulsion rocketPropulsion;
    public Shooting shooting;
    public Transform target;

    public float chaseSpeed = 1f;
    public float shootRange = 10f;
    public float shootInterval = 1f;

    private float shootTimer = 0f;

    void Update()
    {
        // Chase the target
        transform.LookAt(target);
        characterMovement.SetCommand(new RunCommand());

        // Shoot at the target if it is in range
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance < shootRange)
        {
            shootTimer -= Time.deltaTime;
            if (shootTimer <= 0f)
            {
                shooting.FireBullet();
                shootTimer = shootInterval;
            }
        }
    }
}
