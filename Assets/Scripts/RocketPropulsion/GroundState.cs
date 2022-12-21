using UnityEngine;

public class GroundState : IState
{
    public void Update(RocketPropulsion propulsion)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            propulsion.SetState(new AscentState());
        }
    }
}