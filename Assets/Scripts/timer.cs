using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;



public class timer : MonoBehaviour
{
    private int sec = 0;
    private int min = 0;
    [SerializeField] private TMP_Text Text;
    private int delta = 1;
    void Start()
    {
       // Text = GameObject.Find("Timer").GetComponent<TMP_Text>();
        StartCoroutine(ITimer());

    }

    IEnumerator ITimer()
    {
        while (true)
        {
            if (sec == 59)
            {
                min++;
                sec = -1;
            }
            sec += delta;
            Text.text= min.ToString("D2")+":"+sec.ToString("D2");
            yield return new WaitForSeconds(1);
        }


    }
}
