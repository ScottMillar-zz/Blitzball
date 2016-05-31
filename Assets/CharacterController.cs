using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {


    public float speed = 12;
    public float rotateSpeed = 100;

    Quaternion targetRotation;
    Rigidbody rigidBody;
    float forwardInput, turnInput;

    Vector3 direction;


    public Vector3 Direction
    {
        get { return direction; }
    }

    public Quaternion TargetRotation
    {
        get { return targetRotation; }
    }

	// Use this for initialization
	void Start ()
    {
        //targetRotation = transform.rotation;
        if (GetComponent<Rigidbody>())
        {
            rigidBody = GetComponent<Rigidbody>();
        }
        else
            Debug.LogError("No rigidbody has been found");
	}

    void GetInput()
    {
        forwardInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");

        direction = new Vector3(turnInput, 0, forwardInput);
    }

    // Update is called once per frame
    void Update ()
    {
        GetInput();
        Turn();
	}

    void FixedUpdate()
    {
        Swim();
    }

    void Swim()
    {
        rigidBody.velocity =  direction * speed;
       
    }

    void Turn()
    {
        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(-direction), Time.deltaTime * rotateSpeed);
        }
        else
            Debug.LogError("Direction is = Vector3.zero");
    }



}
