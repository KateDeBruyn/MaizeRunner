using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootInput : MonoBehaviour
{
    private PlayerControls playerControls;
    [HideInInspector] public bool aim;
    [HideInInspector] public bool shoot;
    private void Awake()
    {
        playerControls = new PlayerControls();

    }

    private void OnEnable()
    {
        playerControls.Enable();
    }
    private void OnDisable()
    {
        playerControls.Disable();
    }

    public void Start()
    {
        playerControls.Player.Aim.performed += ctx => aim = ctx.ReadValueAsButton();
        playerControls.Player.Aim.canceled += ctx => aim = ctx.ReadValueAsButton();
        playerControls.Player.Shoot.performed += ctx => shoot = ctx.ReadValueAsButton();
        playerControls.Player.Aim.canceled += ctx => aim = ctx.ReadValueAsButton();
    }

  
}
