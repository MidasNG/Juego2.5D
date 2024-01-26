using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCall : MonoBehaviour
{
    [SerializeField] private CharacterControls character;
    
    private void Jump()
    {
        character.Jump();
    }
}
