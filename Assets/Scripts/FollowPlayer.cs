using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Camera _thirdPersonCamera;
    [SerializeField] private Camera _firstPersonCamera;

    [SerializeField] private GameObject _target;

    private Vector3 _offsetFirstPerson = new Vector3(0, 2, 1);
    private Vector3 _offsetThirdPerson = new Vector3(0, 6, -9);

    void LateUpdate()
    {
        _thirdPersonCamera.transform.position = _target.transform.position + _offsetThirdPerson;
        _firstPersonCamera.transform.position = _target.transform.position + _offsetFirstPerson;
    }
}
