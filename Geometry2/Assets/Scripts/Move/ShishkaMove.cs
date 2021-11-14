using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShishkaMove : MonoBehaviour
{
    float speed = 1f;
    int skalirovanie = 150;
    void Start()
    {
        speed = 1f;
    }
    void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("Score") / skalirovanie >= 1)
        {
            skalirovanie += 200;
            speed += 1f;
        }
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -2)
            Destroy(gameObject);
    }

}
