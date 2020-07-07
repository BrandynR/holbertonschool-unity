/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform t;
    private Vector3 offset;
    private int inverted;

    public GameObject player;
    public float turnSpeed = 5.0f;

    public bool isInverted;

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
        offset = t.position - player.transform.position;
        if (PlayerPrefs.GetString("IsInverted") != "")
            isInverted = bool.Parse(PlayerPrefs.GetString("IsInverted"));
        else
            isInverted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isInverted)
        {
            inverted = -1;
        }
        else
        {
            inverted = 1;
        }
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * inverted * turnSpeed, Vector3.left) * offset;
        t.position = player.transform.position + offset * Time.timeScale;
        transform.LookAt(player.transform.position);
    }
}*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Transform playerPos;
    public Vector3 offset;
    // public float speedH = 2.0f;
    // public float speedV = 2.0f;
    // private float x = 0.0f;
    // private float y = 0.0f;
    public bool rotateAround = true;
    public float rotationSpeed = 5.0f;
    public bool LookAtPlayer = false;
    //public bool isInverted;
    //public Toggle inverted;
    //public float mouseY = 0;
    // Start is called before the first frame update
    void Start()
    {
        //inverted = this.GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerPos.position + offset;
        if (rotateAround)
        {
            if (Input.GetMouseButton(1))
            {
                Quaternion camTurn = 
                    Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);
                
                offset = camTurn * offset;
            // x +=speedH * Input.GetAxis("Mouse X");
            // y += speedV * Input.GetAxis("Mouse Y");
            // transform.eulerAngles = new Vector3(y, x, 0.0f);
            }
        }
        if (LookAtPlayer || rotateAround)
            transform.LookAt(playerPos);

    //     if (inverted.isOn)
    //     {
    //         isInverted = true;
    //         transform.RotateAround(transform.position, transform.right, Input.GetAxis("Mouse Y") * mouseY);
    //     }
    //     else
    //         isInverted = false;
    }
}
