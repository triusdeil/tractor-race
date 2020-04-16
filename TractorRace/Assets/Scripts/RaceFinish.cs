using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{
    public GameObject MyCar;
    public GameObject FinishCam;
    public GameObject ViewModes;
    public GameObject LevelMusic;   
    public GameObject CompleteTrig;
    public AudioSource FinishMusic;

     void OnTriggerEnter() {
         this.GetComponent<BoxCollider>().enabled = false;
         MyCar.SetActive (false);
         CompleteTrig.SetActive(false);
         MyCar.GetComponent<Movement>().enabled = false;
         MyCar.SetActive(true);
         FinishCam.SetActive(true);
         ViewModes.SetActive(false);
        FinishMusic.Play();
     }
}
