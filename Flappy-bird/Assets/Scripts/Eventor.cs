using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Eventor : MonoBehaviour
{
    public UnityEvent onMouseClicked;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onMouseClicked?.Invoke();
        }
    }
}
