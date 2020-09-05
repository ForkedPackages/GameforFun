using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour {
   private GameObject pool;
   private bool _bounce = false;
   private Rigidbody _myRG;
    // Start is called before the first frame update
   void Awake () {
        _myRG = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update () {
        if (_bounce == true) {
            _myRG.AddForce (new Vector3 (0, 5, 0), ForceMode.Impulse);
            _bounce = false;
        }
    }

    void OnCollisionEnter (Collision other) {
        _bounce = true;
  
    }
}




