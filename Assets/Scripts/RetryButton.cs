using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{

    private int counter = 0;

    void Start()
    {
    }

    public void OnClick()
    {
        SceneManager.LoadScene("Game");

    }
}