using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polka : MonoBehaviour
{
    [SerializeField] Rigidbody mainRigidbody;

    [SerializeField] float maxMoveSpeed;
    [SerializeField][Range(0f, 1f)] float lerpSpeed;

    private InputSystem inputSystem;

    private float currentSpeed;
    private Vector3 moveDirection;

    private float XDirection = 0f;
    private float YDirection = 0f;
    private float ZDirection;

    private void Start()
    {
        inputSystem = FindObjectOfType<InputSystem>();
    }

    private void FixedUpdate()
    {
        MovePolka();
    }

    private void MovePolka()
    {
        currentSpeed = mainRigidbody.velocity.z;
        ZDirection = inputSystem.PolkaDirection;

        ZDirection = Mathf.Lerp(currentSpeed, maxMoveSpeed * ZDirection, lerpSpeed);

        moveDirection = new Vector3(YDirection, XDirection, ZDirection);

        mainRigidbody.velocity = moveDirection;
    }
}
