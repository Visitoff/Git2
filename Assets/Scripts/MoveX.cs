using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class MoveX : MonoBehaviour
{
    private float lookspeed = 3f;
    private Rigidbody rb;
    private Vector3 rotation = Vector3.zero;
    private void Start()

    {

        rb = GetComponent<Rigidbody>();

    }

    
    public void Rotate(Vector3 _rotation)

    {

        rotation = _rotation;

    }
    private void FixedUpdate()
    {
        Camrotate();
    }
    void Camrotate()
    {
        float yRot = Input.GetAxisRaw("Mouse X");
        float xRot = Input.GetAxisRaw("Mouse Y");
        Vector3 rotation = new Vector3(xRot, yRot, 0f) * lookspeed;

        Rotate(rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
