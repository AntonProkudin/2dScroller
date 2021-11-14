using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBearMain : MonoBehaviour
{
    public GameObject[] wall;
    private float[] positions = { -3f };
    void Start()
    {
        StartCoroutine(spawn());
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
            new Vector3(positions[Random.Range(0, positions.Length)], 0.32f, 0),
            Quaternion.Euler(new Vector3(0, 0, 0)));
            yield return new WaitForSeconds(10f);

        }
    }
}
