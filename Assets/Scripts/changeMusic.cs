using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMusic : MonoBehaviour
{
    public GameObject music1;
    public GameObject music2;
    public GameObject music3;

    public GameObject rabbit;

    public void Music1()
    {

        music1.SetActive(true);
        music2.SetActive(false);
        music3.SetActive(false);

    }
    public void Music2()
    {

        music1.SetActive(false);
        music2.SetActive(true);
        music3.SetActive(false);

    }
    public void Music3()
    {

        music1.SetActive(false);
        music2.SetActive(false);
        music3.SetActive(true);

    }
    public void Rabbit()
    {

        rabbit.SetActive(true);
        

    }



}
