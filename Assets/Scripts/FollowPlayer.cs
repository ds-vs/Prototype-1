using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    private Vector3 _offset = new Vector3(0, 6, -9);

    // Start is called before the first frame update
    void Start()
    {   
        
    }

    void LateUpdate()
    {
        transform.position = _target.transform.position + _offset;
    }
}
