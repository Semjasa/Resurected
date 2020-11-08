using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    void LateUpdate()
    {
        transform.LookAt(_target.transform);
    }
}
