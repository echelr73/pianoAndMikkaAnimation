using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadGameScene", 9f);
    }

    void LoadGameScene()
    {
        SceneManager.LoadScene("MikkaParque");
    }
}
