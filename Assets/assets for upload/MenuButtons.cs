using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject MenuPanel;
     public GameObject CharacterSelectPanel;
     public GameObject CreditsPanel;
    
   
    void Start()
    {
        MenuPanel.SetActive(true);
        CharacterSelectPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        
    }
    public void ShowCharacterSelectPanel()
    {
        MenuPanel.SetActive(false);
        CharacterSelectPanel.SetActive(true);
        
    }

    public void ShowMenuPanel()
    {
        MenuPanel.SetActive(true);
        CharacterSelectPanel.SetActive(false);
        CreditsPanel.SetActive(false);
      
    }
    public void ShowCreditsPanel()
    {
        MenuPanel.SetActive(false);
        CreditsPanel.SetActive(true);
        
    }
   
    public void ClickExit()

    {
        Application.Quit();
    }


}

 