using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroText : MonoBehaviour
{
    [SerializeField] private GameObject introTextImage;
    [SerializeField] private GameObject introText;
    [SerializeField] private GameObject cube;
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
        cube.SetActive(false);
        introTextImage.SetActive(false);
        introText = introTextImage;
        mouseLook.MouseLookEnabled = true;
        moveMenu.cursorActive = introTextImage.activeSelf;
    }

    public void OpenIntroText()
    {
        cube.SetActive(true);
        introTextImage.SetActive(true);
        introText.SetActive(true);
        mouseLook.MouseLookEnabled = false;
        moveMenu.cursorActive = introTextImage.activeSelf;
    }
}
