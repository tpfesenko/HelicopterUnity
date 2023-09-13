using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    private Rigidbody rigidbody;

    [SerializeField] private float _responsiveness = 500f;
    [SerializeField] private float _throttleAmt = 25f;
    private float _throttle;

    private float _roll;
    private float _pitch;
    private float _yaw;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        HandleInputs();
    }
}
