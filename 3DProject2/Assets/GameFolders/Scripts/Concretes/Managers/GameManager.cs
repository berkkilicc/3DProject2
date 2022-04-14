using Project2.Abstracts.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Project2.Managers
{
    public class GameManager : SingletonNoboBehaviorObject<GameManager>
    {
        public event System.Action OnGameStop;


        void Awake()
        {
            SingletonThisObject(this);
        }

        public void StopGame()
        {
            Time.timeScale = 0f;
            OnGameStop?.Invoke();

            //if (OnGameStop !=null)
            //{
            //    OnGameStop();
            //}


        }

        public void LoadScene()
        {
            //load islemleri
           


        }

        public void LoadScene(string sceneName)
        {
            StartCoroutine(LoadSceneAsync(sceneName));
        }


        private IEnumerator LoadSceneAsync(string SceneName)
        {
            Time.timeScale = 1f;
            yield return SceneManager.LoadSceneAsync(SceneName);
        }
        

        public void ExitGame()
        {
            Debug.Log("Exit on clicked");
            Application.Quit();
        }


    }

}


