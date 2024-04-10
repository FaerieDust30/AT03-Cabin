using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationMovementMenu : MonoBehaviour
{
    [SerializeField] private GameObject menu;

    private MouseLook mouseLook;
    private bool cursorActive
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
