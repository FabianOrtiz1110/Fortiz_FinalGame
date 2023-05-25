using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public AudioSource playSound;
    private bool displayBox = false;



    void OnTriggerEnter(Collider other)
    {
        displayBox = true;
        Destroy(gameObject, 7f);
        playSound.Play();
    }

    void OnGUI()
    {
        if (displayBox)
        {
            GUI.Box(new Rect(Screen.width / 2 - 700, Screen.height - 850, 270, 40), "\"It sound like its coming from the kitchen\"");
        }
    }
}
