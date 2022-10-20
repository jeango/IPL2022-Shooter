using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

namespace ipl2022.Guillaume
{
    public class MovementController : MonoBehaviour
    {
        [SerializeField] private float speed;
    
        void Update()
        {
            Move();
        }
    
        private void Move() {
            Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            var newPos = transform.position;
            newPos += dir * Time.deltaTime * speed;
            transform.position = newPos;
        }
    }
}
