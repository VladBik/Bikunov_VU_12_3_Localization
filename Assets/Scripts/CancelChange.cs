using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelChange : MonoBehaviour {
    // смена вида камеры      
    public GameObject NoramlCam;
    public GameObject FarCam;
    public GameObject FPCam;
    public int CamMode;
    
	
	void Update () {
        // смена вида по клику на пробел
        if (Input.GetKey(KeyCode.Space))
        {
            if(CamMode == 3)
            {
                CamMode = 0;
            }
            else
            {
                CamMode += 1;
            } StartCoroutine(ModeChange());

        }
	}
    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if(CamMode == 0)
        {
            NoramlCam.SetActive(true);
            FPCam.SetActive(false);
            FarCam.SetActive(true);

        }
        if (CamMode == 1)
        {
            FarCam.SetActive(true);
            NoramlCam.SetActive(false);
            FPCam.SetActive(false);
        }
        if (CamMode == 2)
        {
            FPCam.SetActive(true);
            FarCam.SetActive(false);
            NoramlCam.SetActive(false);
        }
    }
}
