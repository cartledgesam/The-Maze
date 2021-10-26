using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
   
  public void GotoMainScene()
    {
        SceneManager.LoadScene(sceneName: "L2_ENDOFTHELINE");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene(sceneName: "menu");
    }
}
