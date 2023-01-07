using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContollerZ : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private float _turnSpeed = 5.0f;

    [SerializeField] private int _playerID;

    private float _horizontalInput;
    private float _verticalInput;

    // Update is called once per frame
    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal" + _playerID);
        _verticalInput = Input.GetAxis("Vertical" + _playerID);

        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _verticalInput);

        transform.Rotate(Vector3.up, Time.deltaTime * _turnSpeed * _horizontalInput);
    }
}
