using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;

    public Transform leftPoint, rightPoint;

    Rigidbody2D enemyRb;
    SpriteRenderer sprEnemy;
    bool isRight;

    void Awake()
    {
        sprEnemy = GetComponent<SpriteRenderer>();
        enemyRb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        sprEnemy.flipX = isRight;

        if (gameObject.transform.position.x < leftPoint.position.x)
        {
            isRight = true;           
        }
        else if (gameObject.transform.position.x > rightPoint.position.x)
        {
            isRight = false;
        }
        if (isRight)
        {
            enemyRb.velocity = new Vector2(speed, enemyRb.velocity.y); 
        }
        else
        {
            enemyRb.velocity = new Vector2(-speed, enemyRb.velocity.y);
        }
    }
}
