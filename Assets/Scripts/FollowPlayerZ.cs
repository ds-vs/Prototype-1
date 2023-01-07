using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerZ : MonoBehaviour
{
    [SerializeField] private Camera _playerCamera;
    [SerializeField] private GameObject _target;

    private Vector3 _offset = new Vector3(0, 6, -9);

    void LateUpdate()
    {
        _playerCamera.transform.position = _target.transform.position + _offset;
    }
}
