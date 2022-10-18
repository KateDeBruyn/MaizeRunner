using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class UIManager : MonoBehaviour
{
    public static bool gamePaused = false;

    public GameObject pauseMenuUI;
    public PlayerControls inputActions;
    public Shooter skooter;

    
    public void Awake()
    {
        
        inputActions = new PlayerControls();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Start()
    {
        skooter = FindObjectOfType(typeof(Shooter)) as Shooter;
        inputActions.UI.Escape.performed += ctx => Pause();
    }
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    if (gamePaused)
        //    {
        //        Debug.Log("game is paused true and escape key pressed");
        //        Resume();
        //    }
        //    else
        //    {
        //        Debug.Log("game is paused false but escape key pressed");
        //        Pause();
        //    }
        //}
    }

    public void Resume()
    {
       // skooter.enabled = true;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Pause()
    {
        if (gamePaused == false)
        {
            //skooter.enabled = false;
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            gamePaused = true;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Resume();
        }
        
    }

    public void LoadMenu()
    {

    }

    public void OnApplicationQuit1()
    {
        Application.Quit();
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }
}
