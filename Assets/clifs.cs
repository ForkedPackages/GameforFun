using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clifs : MonoBehaviour {
    public GameObject father;

    // Start is called before the first frame update
    void Start () {
    father = GameObject.Find("Father");
    }

    // Update is called once per frame
    void Update () { 
        
         transform.rotation = father.transform.rotation;
            
    }
}