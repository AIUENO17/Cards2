﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public void SetActive()
    {
        SceneManager.LoadScene("Game");


    }
}
