using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForest : MonoBehaviour
{
    public float speed = 3f;
    public GameObject forest;
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.x < -5f)
            Instantiate(forest, new Vector3(-20.2f, -0.07f, 100f), Quaternion.identity);
            Destroy(gameObject);
    }
}
