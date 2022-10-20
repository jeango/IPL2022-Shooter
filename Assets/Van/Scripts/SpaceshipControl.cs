using UnityEngine;
namespace Ipl2022.Van
{
    public class SpaceshipControl : MonoBehaviour
    {
        [SerializeField] private float speed;

        // Update is called once per frame
        void Update()
        {
            Move();
        }

        private void Move()
        {
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");

            Vector2 direction = new Vector2(x, y).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}