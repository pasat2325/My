using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class NewSectionTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject roadSection;
    public float loc;
    public void OnTriggerEnter(Collider other){

        if(other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(roadSection,new Vector3(0,0,loc), Quaternion.Euler(new Vector3(0, 270, 0)));
           
           
        }
    }
}
