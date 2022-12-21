using UnityEngine;

public class Powerup : MonoBehaviour
{
    public IPowerupStrategy strategy;

    public void Use()
    {
        strategy.Use(this);
    }
}