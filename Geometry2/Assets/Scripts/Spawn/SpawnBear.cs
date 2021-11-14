using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBear : MonoBehaviour
{
    int chet;
    public GameObject[] wall;
    private float[] positions = { -3f };
    //void Start()
    //{
    //    StartCoroutine(spawn());
    //}
    void Update()
    {
        chet++;
        if (chet == 750)
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
            new Vector3(positions[Random.Range(0, positions.Length)], -1.1f, 0),
            Quaternion.Euler(new Vector3(0, 0, 0)));
            yield return new WaitForSeconds(20f);

        }
    }
}
