using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Lanterna : MonoBehaviour
{

    public GameObject ON;
    public GameObject OFF;
    private bool isON;


    void Start()
    {
        ON.SetActive(false);
        OFF.SetActive(true);
        isON = false;
    }
    void Update(){
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (isON)
            {
                ON.SetActive(false);
                OFF.SetActive(true);
            }

            if (!isON)
            {
                ON.SetActive(true);
                OFF.SetActive(false);
            }
            isON = !isON;
        }
    }
}
