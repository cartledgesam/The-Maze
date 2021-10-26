using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    
    public Button m_LevelOne, m_LevelTwo;
    public int WhichLevel;

    void Start()
    {
       
        m_LevelOne.onClick.AddListener(TaskOnClick);
        m_LevelTwo.onClick.AddListener(TaskOnClick2);
        
    }

    void TaskOnClick()
    {

        Debug.Log("You have clicked the button!");
        WhichLevel = 1;
        Debug.Log(WhichLevel);

    }

    void TaskOnClick2()
    {

        Debug.Log("You have clicked the button!");
        WhichLevel = 2;
        Debug.Log(WhichLevel);

    }

   
   

}