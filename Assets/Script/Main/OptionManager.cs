using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OptionManager : MonoBehaviour
{

    public static OptionManager instance;

    public void Awake()
    {
        OptionManager.instance = this;
    }

    public OptionManager(){
    }

    public void ResetCharacter(){
        Debug.Log("reset character");
        SaveManager.instance.ResetCharacterData();
		SceneManager.UnloadScene("MainScene");
        SceneManager.LoadScene("SplashScene");
    }
    
}
