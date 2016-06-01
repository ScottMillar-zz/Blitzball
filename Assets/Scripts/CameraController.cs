using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public Transform target;
    public float cameraSmooth = 0.09f;
    public Vector3 offsetFromTarget = new Vector3(0, 6, -8);
    public float xTilt = 10;

    Vector3 destination = Vector3.zero;
    CharacterController charController;

    float rotateSpeed = 0;

    // Use this for initialization
    void Start()
    {
        setTarget(target);
    }

    public void setTarget(Transform t)
    {
        target = t;

        if (target != null)
        {
            if (target.GetComponent<CharacterController>())
            {
                charController = target.GetComponent<CharacterController>();
            }
            else
                Debug.LogError("Camera's target needs a character controller.");
        }
        else
            Debug.LogError("setTarget has no targer.");

    }

    void LateUpdate()
    {
        MoveTo();

        //LookAt();
    }

    void MoveTo()
    {
        destination = charController.Direction + offsetFromTarget;
        destination += target.position;
        transform.position = destination;
    }

    //void LookAt()
    //{
    //    float eulerYAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, target.eulerAngles.y, ref rotateSpeed, cameraSmooth);
    //    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, eulerYAngle, 0);
    //}

}

