using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPause : MonoBehaviour
{
    //public GameObject Pausado;
    bool isPause = false;

    public void PauseGame()
    {
        if (isPause)
        {
            Time.timeScale = 1;
            //Pausado.SetActive(false);
            isPause = false;



        }
        else
        {
            //Pausado.SetActive(true);
            Time.timeScale = 0;
            
            isPause = true;
            

        }
    }

}
