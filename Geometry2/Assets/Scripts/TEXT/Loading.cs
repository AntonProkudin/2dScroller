using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Loading : MonoBehaviour
{
    char tch = '.';
    short i;
    void Start()
    {
        GetComponent<Text>().text = "Loading";
        StartCoroutine(Chet());
    }

    IEnumerator Chet()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            i++;
            if(i == 4)
            {
                i = 0;
                GetComponent<Text>().text = "Loading";
            }
            GetComponent<Text>().text = "Loading"+ tch;
        }
    }
}
