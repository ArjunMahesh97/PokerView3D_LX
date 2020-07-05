using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroLookCam : MonoBehaviour
{
    Quaternion initialRotation;

    // Start is called before the first frame update
    void Start()
    {
        initialRotation = transform.rotation;

        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y, -Input.gyro.rotationRateUnbiased.z/2); // Z gyro was too sensitive
    }

    public void RecenterCam()
    {
        transform.rotation = initialRotation;
    }
}
