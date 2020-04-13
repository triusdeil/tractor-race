using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar01 : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
     
    public int MarckTracker;

    void Update() {
        if (MarckTracker == 0)
        {
            TheMarker.transform.position = Mark01.transform.position;
        }
        if (MarckTracker == 1)
        {
            TheMarker.transform.position = Mark02.transform.position;
        }
        if (MarckTracker == 2)
        {
            TheMarker.transform.position = Mark03.transform.position;
        }
        if (MarckTracker == 3)
        {
            TheMarker.transform.position = Mark04.transform.position;
        }
        if (MarckTracker == 4)
        {
            TheMarker.transform.position = Mark05.transform.position;
        }
        if (MarckTracker == 5)
        {
            TheMarker.transform.position = Mark06.transform.position;
        }
       
    }
    IEnumerator OnTriggerEnter(Collider collision) {
        if(collision.gameObject.tag == "DreamCar01"){
            this.GetComponent<BoxCollider>().enabled = false;
            MarckTracker += 1;
            if(MarckTracker == 6){
                MarckTracker =0;
            }
            yield return new WaitForSeconds (1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
