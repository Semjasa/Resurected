using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private float dumping = 1;
    private Vector3 _offset;

    void LateUpdate()
    {
        var currentAngle = transform.eulerAngles.y;
        var desiredAngle = _target.transform.eulerAngles.y;
        var angle = Mathf.LerpAngle(currentAngle, desiredAngle, Time.deltaTime * dumping);
        var rotation = Quaternion.Euler(0, angle, 0);

        transform.position = _target.transform.position - (rotation * _offset);
        transform.LookAt(_target.transform);
    }
}
