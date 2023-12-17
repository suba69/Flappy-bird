using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAnimation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float takeoffRotation, landingRotation;

    private float rotZ;

    public void ApplyRotation(float velocityX)
    {
        if (rotZ > landingRotation)
        {
            float offset = 1f;
            if (velocityX > 0.5f) offset = velocityX;
            offset = Mathf.Abs(offset);

            rotZ -= rotationSpeed * Time.deltaTime / offset;
            transform.localEulerAngles = new Vector3(0, 0, rotZ);
        }
    }

    public void StartRotation()
    {
        rotZ = takeoffRotation;
    }
}
