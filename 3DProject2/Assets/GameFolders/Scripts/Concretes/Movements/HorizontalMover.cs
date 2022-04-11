using Project2.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project2.Movements
{
    public class HorizontalMover
    {
        PlayerController _playerController;

        public HorizontalMover(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void TickFixed(float horizantal, float moveSpeed)
        {
            if (horizantal == 0f) return;

            _playerController.transform.Translate(Vector3.right * horizantal * Time.deltaTime * moveSpeed);
            
        }

    }

}
