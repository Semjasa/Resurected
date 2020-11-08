using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 10;
    [SerializeField] private float _turningSpeed = 60;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * _turningSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * _movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }
}
