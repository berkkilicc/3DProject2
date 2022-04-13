using Project2.Movements;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Project2.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] float _movespeed = 10f;
        [SerializeField] float _maxLifeTime = 10f;


        VerticalMover _mover;
        float _currentLifeTime = 0f;

        public float MoveSpeed => _movespeed; 

        private void Awake()
        {
            _mover = new VerticalMover(this);
        }

        private void Update()
        {
            _currentLifeTime += Time.deltaTime;

            if (_currentLifeTime > _maxLifeTime)
            {
                _currentLifeTime = 0f;
                KillYourSlef();
            }

        }

       
        private void FixedUpdate()
        {
            _mover.FixedTick();
        }

        private void KillYourSlef()
        {
            Destroy(this.gameObject);
        }



    }
}

