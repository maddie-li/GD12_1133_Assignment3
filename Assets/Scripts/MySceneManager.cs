using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    private void StartGameScene()
    {
        SceneManager.LoadScene("MainLevel");
    }
}
