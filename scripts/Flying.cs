using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Flying : MonoBehaviour
{
    [SerializeField]
    float thrusterforce = 1000f;
    [SerializeField]
    float tiltingforce = 100f;
    bool thrust = false;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float tilt = Input.GetAxis("Horizontal");
        thrust = Input.GetKey(KeyCode.Space);
        if (!Mathf.Approximately(tilt, 0f))
        {
            rb.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.eulerAngles + (new Vector3(0f, 0f, (tilt * tiltingforce * Time.deltaTime))));
        }
        rb.freezeRotation = false;
    }
    void FixedUpdate()
    {
        if (thrust)
        {
            rb.AddRelativeForce(Vector3.up * thrusterforce * Time.deltaTime);
        }
    }
}