using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateMenu : MonoBehaviour
{

    [SerializeField] GameObject menuUI;

    [SerializeField] InputActionReference activeButtonReference;


    // Start is called before the first frame update
    void Start()
    {
        menuUI.SetActive(false);

        activeButtonReference.action.performed += ToggleMenu;

    }

    private void ToggleMenu(InputAction.CallbackContext obj)
    {
        menuUI.SetActive(!menuUI.activeInHierarchy);
    }

}
