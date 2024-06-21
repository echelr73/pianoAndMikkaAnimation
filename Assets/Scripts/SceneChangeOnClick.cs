using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeOnClick : MonoBehaviour
{

    public void OnButtonClick()
    {
        SceneManager.LoadScene("Botonera");
    }
}
