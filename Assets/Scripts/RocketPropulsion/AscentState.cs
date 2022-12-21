using UnityEngine;

public class AscentState : IState
{
    public void Update(RocketPropulsion propulsion)
    {
        propulsion.Ascend();

        if (Input.GetKey(KeyCode.W))
        {
            propulsion.Boost();
        }
        else if (Input.GetKeyUp(KeyCode.Space) || Input.GetKey(KeyCode.S))
        {
            propulsion.SetState(new DescentState());
        }
    }
}