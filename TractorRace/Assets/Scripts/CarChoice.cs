using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject BlackTractor;
    public GameObject OrangeTractor;
    public GameObject GreenTractor;
    public int TractorImport;
    void Start()
    {
        TractorImport = GlobalTractor.TractorType;
        if(TractorImport == 1){
            BlackTractor.SetActive (true);
        }
         if(TractorImport == 2){
            OrangeTractor.SetActive (true);
        }
         if(TractorImport == 3){
            GreenTractor.SetActive (true);
        }
    }

}
