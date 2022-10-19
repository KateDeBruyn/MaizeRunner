using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour
{
    public static bool gamePaused = false;

    public GameObject pauseMenuUI;
    public GameObject helpMenu;

    public PlayerControls inputActions;
    public Shooter skooter;

    private void OnEnable()
    {
        inputActions.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }

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
        
    }

    public void Resume()
    {
        skooter.enabled = true;
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
            skooter.enabled = false;
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

    public void LoadHelp()
    {
        helpMenu.SetActive(true);
    }

    public void Back()
    {
        helpMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }

    
}
