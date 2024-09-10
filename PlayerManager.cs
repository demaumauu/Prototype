using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //declaring everything
    InputManager inputManager;
    PlayerLocomotion playerLocomotion;

    private void Awake()
    {
        // calling scripts
        inputManager = GetComponent<InputManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
    }

    private void Update()
    {
        inputManager.HandleAllInputs();
    }

    private void FixedUpdate()
    {
        playerLocomotion.HandleAllMovement(); //better when moving a rigid body
    }
}
