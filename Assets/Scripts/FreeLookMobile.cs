using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FreeLookMobile : MonoBehaviour
{

    private Vector3 firstpoint;
    private Vector3 secondpoint;
    private float xAngle = 0.0f; //angle for axes x for rotation
    private float yAngle = 0.0f;
    private float xAngTemp = 0.0f; //temp variable for angle
    private float yAngTemp = 0.0f;

    [SerializeField] float xMinTouch = 75f;
    [SerializeField] float yMinTouch = 75f;

    [SerializeField] float initialXAngle = 90f;
    [SerializeField] float initialYAngle = -90f;

    [SerializeField] float heightSpanAngle = 90f;
    [SerializeField] float widthSpanAngle = 180f;


    void Start()
    {

        firstpoint = new Vector3(0, 0, 0);
        secondpoint = new Vector3(0, 0, 0);

        xAngle = initialXAngle;
        yAngle = initialYAngle;

        transform.rotation = Quaternion.Euler(initialXAngle, initialYAngle, 0.0f);
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            //Touch began, save position
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                firstpoint = Input.GetTouch(0).position;
                xAngTemp = xAngle;
                yAngTemp = yAngle;
            }
            //Move finger by screen
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                secondpoint = Input.GetTouch(0).position;
                float yDiff = secondpoint.y - firstpoint.y;
                float xDiff = secondpoint.x - firstpoint.x;

                if (Math.Abs(xDiff) <= xMinTouch)
                {
                    xDiff = 0;
                }
                
                if (Math.Abs(yDiff) <= yMinTouch)
                {
                    yDiff = 0;
                }

                yAngle = yAngTemp - yDiff * heightSpanAngle / Screen.height;

                if (yAngle < 0)
                    yAngle += 360;
                if (yAngle > 360)
                    yAngle -= 360;

                if (yAngle > 90 && yAngle < 270)
                {                    
                    xAngle = xAngTemp - xDiff * widthSpanAngle / Screen.width;
                }
                else
                    xAngle = xAngTemp + xDiff * widthSpanAngle / Screen.width;

                if (xAngle < 0)
                    xAngle += 360;

                if (xAngle > 360)
                    xAngle -= 360;

                transform.rotation = Quaternion.Euler(-yAngle, -xAngle, 0.0f);

            }
        }
    }
}
