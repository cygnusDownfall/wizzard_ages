using UnityEngine.SceneManagement;
using UnityEngine;

//using System.Collections;

public class mainmenupanel : MonoBehaviour
{
    
    
    public void LoadGame(int key)
    {
        PlayerPrefs.SetInt("keysave", key);



        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
