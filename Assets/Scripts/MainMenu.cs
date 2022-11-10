using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BattleLords.Menu
{ 

    public class MainMenu : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneManager.LoadScene("Level_01");
        }

        public void QuitGame()
        {
                Application.Quit();
        }
    }
}