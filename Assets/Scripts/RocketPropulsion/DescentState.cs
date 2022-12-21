using UnityEngine;

public class DescentState : IState
{
    public void Update(RocketPropulsion propulsion)
    {
        propulsion.Descend();

        if (Input.GetKeyUp(KeyCode.Space))
        {
            propulsion.SetState(new GroundState());
        }
    }
}