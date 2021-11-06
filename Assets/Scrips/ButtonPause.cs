using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPause : MonoBehaviour
{

    bool isPause = false;

    public void PauseGame()
    {
        if (isPause)
        {
            Time.timeScale = 1;
            isPause = false;

        }
        else
        {
            Time.timeScale = 0;
            isPause = true;
        }
    }

}
