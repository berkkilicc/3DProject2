using Project2.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project2.Uis
{
    public class MenuPanel : MonoBehaviour
    {
     public void StartButton()
        {
            GameManager.Instance.LoadScene();
        }

        public void ExitButton()
        {
            GameManager.Instance.ExitGame();
        }




    }

}
