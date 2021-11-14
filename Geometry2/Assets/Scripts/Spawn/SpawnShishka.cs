using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShishka : MonoBehaviour
{
    int chet;
    public GameObject[] wall;
    private float[] positions = { -0.48f, -0.1f, 0.3f, 0.5f, 0.8f };
    //void Start()
    //{
    //    StartCoroutine(spawn());
    //}
    void Update()
    {
        chet++;
        if (chet == 300)
            LoadSpawn();
    }
    void LoadSpawn()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(wall[Random.Range(0, wall.Length)], 
            new Vector3(positions[Random.Range(0, positions.Length)], 3f, 0),
            Quaternion.Euler(new Vector3(0,0,0)));
            yield return new WaitForSeconds(2f);

        }
    }
}
