using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void HomeButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
