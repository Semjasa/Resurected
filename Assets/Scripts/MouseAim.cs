using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private float _rotationSpeed = 5;
    private Vector3 _offset;

    void Start()
    {
        _offset = _target.transform.position - transform.position;
    }

    void LateUpdate()
    {
        var horizontal = Input.GetAxis("Mouse X") * _rotationSpeed;
        _target.transform.Rotate(0, horizontal, 0);

        var desireAngle = _target.transform.eulerAngles.y;
        var rotation = Quaternion.Euler(0, desireAngle, 0);
        transform.position = _target.transform.position - (rotation * _offset);

        transform.LookAt(_target.transform);
    }
}
