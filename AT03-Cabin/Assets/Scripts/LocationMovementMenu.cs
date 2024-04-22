using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Faye Butler - 22/04/2024

public class LocationMovementMenu : MonoBehaviour
{
    [Tooltip("The image containing the navigation buttons.")]
    [SerializeField] public GameObject menu;

    private MouseLook mouseLook;
    public bool cursorActive
    {
        set
        {
            Cursor.visible = value;
            if(value == true)
            {
                Cursor.lockState = CursorLockMode.Confined;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    private void Awake()
    {
        mouseLook = FindObjectOfType<MouseLook>();
    }
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ToggleMenu();
    }

    public bool ToggleMenu()
    {
        if (Input.GetButtonDown("Jump") == true)
        {
            menu.SetActive(!menu.activeSelf);
            mouseLook.MouseLookEnabled = !menu.activeSelf;
            cursorActive = menu.activeSelf;
            return true;
        }
        return false;
    }
}
