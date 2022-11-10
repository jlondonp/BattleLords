using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BattleLords.Menu
{
    public class StoreMenu : MonoBehaviour
    {
        public void GotoFightScene()
        {
            SceneManager.LoadScene("Level_01");
        }

    }
}