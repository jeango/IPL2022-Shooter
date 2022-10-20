using UnityEngine;

namespace Ipl2022.Van
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private float speed;

        // Update is called once per frame
        void Update()
        {
            Vector2 pos = transform.position;
            pos = new Vector2(pos.x, pos.y + speed * Time.deltaTime);
            transform.position = pos;

            CheckOffScreen();
        }

        // If the bullet goes outside of the screen, destroy it
        private void CheckOffScreen()
        {
            Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
            if (transform.position.y > max.y)
            {
                Destroy(gameObject);
            }
        }
    }
}