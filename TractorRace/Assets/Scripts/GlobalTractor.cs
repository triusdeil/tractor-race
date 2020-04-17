using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalTractor : MonoBehaviour
{
    public static int TractorType; 
    public GameObject TrackWindow;
    
    public void TractorBlack(){
        TractorType = 1;
        TrackWindow.SetActive(true);
    }

    public void TractorOrange(){
        TractorType = 2;
        TrackWindow.SetActive(true);
    }

    public void TractorGreen(){
        TractorType = 3;
        TrackWindow.SetActive (true);
    }
}
