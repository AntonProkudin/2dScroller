using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class Hero : MonoBehaviour
{
    void Update()
    {

        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        transform.position = new Vector3(pos.x, pos.y, transform.position.z);

    }

    
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
            Death();
        }

    }
    private void Death()
    {
        int timer = 0;
        while (timer < 2000000)
        {
            timer++;
        }
        if(timer>=1000)
         SceneManager.LoadScene(5);
    }
}
