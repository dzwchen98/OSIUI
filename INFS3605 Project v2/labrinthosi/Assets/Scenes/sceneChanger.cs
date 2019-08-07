using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    public void changeScene(string sceneName) {
        Application.LoadLevel(sceneName);
        SceneManager.LoadScene("TestLoad", LoadSceneMode.Additive);
    }
}
