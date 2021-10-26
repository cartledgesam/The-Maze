using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    
    public Button m_CharacterOne, m_CharacterTwo, m_CharacterThree;
    public int WhichCharacter;

    void Start()
    {
        
       //m_CharacterOne.onClick.AddListener(TaskOnClick);
       // m_CharacterTwo.onClick.AddListener(TaskOnClick2);
       //m_CharacterThree.onClick.AddListener(TaskOnClick3);
    }

    public void TaskOnClick()
    {
      
        Debug.Log("You have clicked the button!");
        WhichCharacter = 1;
        Debug.Log(WhichCharacter);

    }

   public void TaskOnClick2()
    {

        Debug.Log("You have clicked the button!");
        WhichCharacter = 2;
        Debug.Log(WhichCharacter);

    }
    public void TaskOnClick3()
    {

        Debug.Log("You have clicked the button!");
        WhichCharacter = 3;
        Debug.Log(WhichCharacter);

    }
    public void GotoMainScene()
    {
       
        SceneManager.LoadScene(sceneName: "L2_ENDOFTHELINE - Copy");
     
    }
    public void GotoMainSceneTwo()
    {
        SceneManager.LoadScene(sceneName: "L2_ENDOFTHELINE - Copy (2)");
    }
    public void GotoMainSceneThree()
    {
        SceneManager.LoadScene(sceneName: "L2_ENDOFTHELINE");
    }
    public void GotoMenuScene()
    {
        SceneManager.LoadScene(sceneName: "menu");
    }
}