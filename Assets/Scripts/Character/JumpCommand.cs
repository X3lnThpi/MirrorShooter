// Command class for jumping
using UnityEngine;

public class JumpCommand : ICommand
{
    public void Execute(CharacterMovement movement)
    {
        movement.Jump();
    }
}