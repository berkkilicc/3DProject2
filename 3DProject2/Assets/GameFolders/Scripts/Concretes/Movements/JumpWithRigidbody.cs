using Project2.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Project2.Movements
{
    public class JumpWithRigidbody
    {
        Rigidbody _rigidbody;


        public JumpWithRigidbody(PlayerController playerController)
        {
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void TickFixed(float jumpForce)
        {
            if (_rigidbody.velocity.y != 0) return;

            Debug.Log(_rigidbody.velocity);


            _rigidbody.velocity = Vector3.zero;
            _rigidbody.AddForce(Vector3.up * Time.deltaTime * jumpForce);
            
        }

    }


}

