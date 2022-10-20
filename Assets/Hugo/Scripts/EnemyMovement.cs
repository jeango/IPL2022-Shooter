using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace proxysoulCode
{
    public class EnemyMovement : MonoBehaviour
    {
        private Vector3 direction;
        [SerializeField] private float speed;
        [SerializeField] private float waitingTime;

        private void Start()
        {
            StartCoroutine(ChangeDirection());
        }

        private void Update()
        {
            direction = transform.right;
            transform.position += direction.normalized * speed * Time.deltaTime;
        }

        private IEnumerator ChangeDirection()
        {
            while (true)
            {
                yield return new WaitForSeconds(waitingTime);
                transform.Rotate(new Vector3(0, 0, 90));
                yield return new WaitForSeconds(waitingTime);
                transform.Rotate(new Vector3(0, 0, 90));
                yield return new WaitForSeconds(waitingTime);
                transform.Rotate(new Vector3(0, 0, 90));
            }
        }
    }
}
