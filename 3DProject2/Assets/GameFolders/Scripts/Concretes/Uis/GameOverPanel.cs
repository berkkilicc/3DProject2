using Project2.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Project2.Uis
{
public class GameOverPanel : MonoBehaviour
{
   public void YesButton()
        {
            GameManager.Instance.LoadScene("Game");
        }

        public void NoButton()
        {
            GameManager.Instance.LoadScene("Menu");
        }

}

}

