// Command class for running
using UnityEngine;

public class RunCommand : ICommand
{
    public void Execute(CharacterMovement movement)
    {
        movement.Run();
    }
}