using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{
	public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;
    public bool doSpin = true;
    public bool doMotion = false;

    // Update is called once per frame
    void Update()
    {
        if (doSpin)
        {
            // rotate around the up axis of the gameObject
            /*transform.Rotate is defined as rotation around each axis. Vector3.up means 0, 1, 0, so only around up axis, times spinSpeed
              so therefore the cube only rotates around the up axis at the spin speed*/
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }
        if (doMotion)
        {
            //move up and down over time
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
        }
    }
}
