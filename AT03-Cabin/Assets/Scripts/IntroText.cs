using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Faye Butler - 10/04/2024 

public class IntroText : MonoBehaviour
{
    [Tooltip("The background image displayed behind the text.")]
    [SerializeField] private GameObject introTextImage;
    [Tooltip("The text displayed for the intro text.")]
    [SerializeField] private GameObject introText;

    private LocationMovementMenu moveMenu;
    private MouseLook mouseLook;

    private void Awake()
    {
        mouseLook = FindObjectOfType<MouseLook>();
        moveMenu = FindObjectOfType<LocationMovementMenu>();
    }
    // Start is called before the first frame update
    void Start()
    {
        introTextImage.SetActive(true);
    }

    private void Update()
    {
        OpenIntroText();
    }

    public void CloseIntroText()
    {
        introTextImage.SetActive(false);
        introText = introTextImage;
        mouseLook.MouseLookEnabled = true;
        moveMenu.cursorActive = introTextImage.activeSelf;
    }

    public void OpenIntroText()
    {
        introTextImage.SetActive(true);
        introText.SetActive(true);
        mouseLook.MouseLookEnabled = false;
        moveMenu.cursorActive = introTextImage.activeSelf;
    }
}
