using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using IJunior.TypedScenes;

public class ButtonLoad : MonoBehaviour
{

    public void TaskOnClick()
    {
        SceneManager.LoadScene(1);
    }
}