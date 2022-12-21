// Command class for walking
using UnityEngine;

public class WalkCommand : ICommand
{
    public void Execute(CharacterMovement movement)
    {
        movement.Walk();
    }
}