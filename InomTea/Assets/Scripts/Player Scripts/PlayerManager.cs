using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    PlayerLocomotion playerLocomotion;

    private void Awake()
    {
        inputManager= GetComponent<InputManager>();
        playerLocomotion= GetComponent<PlayerLocomotion>();
    }

    // Update is called once per frame
   private void Update()
    {
        inputManager.HandleAllinputs();
    }

    private void FixedUpdate()
    {
        playerLocomotion.HandleAllMovement();
    }
}
