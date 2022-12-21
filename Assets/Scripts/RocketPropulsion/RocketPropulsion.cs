using Unity.VisualScripting;
using UnityEngine;

public class RocketPropulsion : MonoBehaviour
{
    public float ascentSpeed = 1f;
    public float descentSpeed = 1f;
    public float boostSpeed = 2f;
    public float boostDuration = 5f;
    public float boostCooldown = 10f;

    private IState currentState;
    private float boostTimer = 0f;
    private float boostCooldownTimer = 0f;

    void Start()
    {
        currentState = new GroundState();
    }

    void Update()
    {
        currentState.Update(this);
        boostTimer -= Time.deltaTime;
        boostCooldownTimer -= Time.deltaTime;
    }

    public void Ascend()
    {
        transform.position += Vector3.up * ascentSpeed * Time.deltaTime;
    }

    public void Descend()
    {
        transform.position += Vector3.down * descentSpeed * Time.deltaTime;
    }

    public void Boost()
    {
        transform.position += transform.forward * boostSpeed * Time.deltaTime;
        boostTimer = boostDuration;
        boostCooldownTimer = boostCooldown;
    }

    public void SetState(IState state)
    {
        currentState = state;
    }

    public bool IsBoosting()
    {
        return boostTimer > 0f;
    }

    public bool IsBoostOnCooldown()
    {
        return boostCooldownTimer > 0f;
    }
}
