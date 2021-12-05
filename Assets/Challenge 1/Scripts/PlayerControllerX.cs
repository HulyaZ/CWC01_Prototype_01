using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20f;

    public float rotationSpeed;
    public float verticalInput;

    private float angle = 0f;
    private float minAngle = -60f;
    private float maxAngle = 60f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.Space))
        {
            speed = 50f;
        }
        else speed = 20f;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);


        angle -= verticalInput * rotationSpeed * Time.deltaTime;
        angle = Mathf.Clamp(angle, minAngle, maxAngle);
        transform.eulerAngles = new Vector3(angle, 0, 0f);

    }
}
