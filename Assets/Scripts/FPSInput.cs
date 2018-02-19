using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FPSInput : MonoBehaviour {

    public float speed = 9;

    private CharacterController charController;

	// Use this for initialization
	void Start () {
        charController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        MoveThePlayer();
	}

    void MoveThePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            MoveForward();
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            MoveBackward();
        }
    }

    void MoveLeft()
    {
        float yAngle = transform.localEulerAngles.y;
        yAngle += -1f;
        transform.localEulerAngles = new Vector3(0, yAngle, 0);
    }

    void MoveRight()
    {
        float yAngle = transform.localEulerAngles.y;
        yAngle += 1f;
        transform.localEulerAngles = new Vector3(0, yAngle, 0);
    }

    void MoveForward()
    {
        Vector3 movement = new Vector3(0, 0, speed * Time.deltaTime);
        movement = transform.TransformDirection(movement);
        charController.Move(movement);
    }

    void MoveBackward()
    {
        Vector3 movement = new Vector3(0, 0, -(speed * Time.deltaTime));
        movement = transform.TransformDirection(movement);
        charController.Move(movement);
    }

}
