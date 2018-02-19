using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

    public float _rotationX = 0;
    public float sensitivityVer = 9.0f;
    public float sensitivityHor = 9.0f;
    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVer;
        _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
        float delta = Input.GetAxis("Mouse X") * sensitivityHor;
        float rotationY = transform.localEulerAngles.y + delta;
        transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
	}
}
