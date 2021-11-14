using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMove : MonoBehaviour
{
    public float speed = 0.9f;
    bool jump = true;
    void FixedUpdate()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < -1.4)
            Destroy(gameObject);
        if (jump)
        {
            transform.rotation = Quaternion.Euler(0, 0, 20);
            if (transform.position.y > -1f)
            {
                jump = false;
            }
            transform.Translate(Vector3.up * 3 * Time.deltaTime);
        }
        else
        {
            if (transform.position.y < -1.55f)
            {
                jump = true;
            }
            transform.rotation = Quaternion.Euler(0, 0, -20);
            transform.Translate(Vector3.down * 3 * Time.deltaTime);

        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

    }
}

