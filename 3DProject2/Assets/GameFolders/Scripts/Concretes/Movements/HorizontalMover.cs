using Project2.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project2.Movements
{
    public class HorizontalMover
    {
        PlayerController _playerController;
        float _moveSpeed;
        float _moveBoundary;

        public HorizontalMover(PlayerController playerController)
        {
            _playerController = playerController;
            _moveSpeed = _playerController.MoveSpeed;
            _moveBoundary = _playerController.MoveBoundary;
        }

        public void TickFixed(float horizantal)
        {
            if (horizantal == 0f) return;

            _playerController.transform.Translate(Vector3.right * horizantal * Time.deltaTime* _moveSpeed);

            float xBoundary = Mathf.Clamp(_playerController.transform.position.x,-_moveBoundary, +_moveBoundary);
            _playerController.transform.position = new Vector3(xBoundary, _playerController.transform.position.y, 0f);
            
        }

    }

}
