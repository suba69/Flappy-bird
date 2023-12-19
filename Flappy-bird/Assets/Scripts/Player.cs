using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    public float ceilingHeight;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
            // Проверяем нажатие клавиши пробела
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }

            // Проверяем сенсорный ввод
            if (Input.touchCount > 0)
            {
                Touch touch = Input.touches[0];

                // Проверяем, что это было начало касания
                if (touch.phase == TouchPhase.Began)
                {
                    rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                }
            }

            // Проверяем, если объект поднимается выше заданной высоты
            if (transform.position.y > ceilingHeight)
            {
                transform.position = new Vector2(transform.position.x, ceilingHeight);
                rb.velocity = Vector2.zero;
            }
        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PipePart"))
        {
            GameManager.instance.Lose();
        }
    }
}
