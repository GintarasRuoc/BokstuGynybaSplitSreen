﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LostPopupGoToMenu : MonoBehaviour
{
    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
