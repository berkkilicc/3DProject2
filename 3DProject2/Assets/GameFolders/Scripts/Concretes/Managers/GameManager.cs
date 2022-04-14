using Project2.Abstracts.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project2.Managers
{
    public class GameManager : SingletonNoboBehaviorObject<GameManager>
    {
        void Awake()
        {
            SingletonThisObject(this);
        }

        public void StopGame()
        {
            Time.timeScale = 0f;
        }

        public void LoadScene()
        {
            //load islemleri
            Debug.Log("Load Scene clicked");


        }

        public void ExitGame()
        {
            Debug.Log("Exit on clicked");
            Application.Quit();
        }


    }

}


