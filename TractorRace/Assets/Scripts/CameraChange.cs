using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject FPCam;
    public int camMode;

    void Update()
    {
        if(Input.GetButton("Viewmode")){
            if(camMode == 2){
                camMode = 0;
            }else
            {
                camMode +=1;
            }
            StartCoroutine(ModeChange ());
        }
    }
    IEnumerator ModeChange(){
        yield return new WaitForSeconds(0.01f);
        if (camMode == 0)
        {
            NormalCam.SetActive(true);
            FPCam.SetActive(false);
        }
        if (camMode == 1)
        {
            FarCam.SetActive(true);
            NormalCam.SetActive(false);
        }
        if (camMode == 2)
        {
            FPCam.SetActive(true);
            FarCam.SetActive(false);
        }
    }
}
