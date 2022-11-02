using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocketflying : MonoBehaviour
{
    public float rotSpeed;
    public float thrust;

    private Vector3 lastPos;
    // Start is called before the first frame update
    void Start()
    {
        lastPos = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(0, 0, rotSpeed));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(0, 0, -rotSpeed));
        }
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody>().AddForce((transform.GetChild(5).transform.position - transform.position).normalized * thrust);
        }
    }
}