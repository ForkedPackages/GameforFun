using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
    // Start is called before the first frame update

    private GameObject theBar;
    public float _sensitivity;
    private Vector3 _mouseReference;
    private Vector3 _mouseOffset;
    private Vector3 _rotation;
    private bool _isRotating;

    void Start () {

        _rotation = Vector3.zero;
    }

    void Update () {
         var mousePos = Input.mousePosition;
         mousePos.x -= Screen.width/2;
         mousePos.y -= Screen.height/2;
         Debug.Log(_isRotating);
        if (Input.GetMouseButtonDown (0)) {
            // rotating flag
            _isRotating = true;
            _mouseReference = mousePos;

        } else if(Input.GetMouseButtonUp(0)) {

            _isRotating = false;

        }
        if (_isRotating == true) {
            // offset
            _mouseOffset = (mousePos - _mouseReference);
            Debug.Log ("offset" + _mouseOffset);
            // apply rotation
            _rotation.y = (_mouseOffset.x + _mouseOffset.y) * _sensitivity;

            // rotate
            transform.Rotate (_rotation);

            // store mouse
            _mouseReference = mousePos;
        }

    }

}