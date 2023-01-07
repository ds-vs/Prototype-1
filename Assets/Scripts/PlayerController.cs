using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private float _turnSpeed = 5.0f;

    private float _horizontalInput;
    private float _verticalInput;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * _turnSpeed * _horizontalInput);
    }
}