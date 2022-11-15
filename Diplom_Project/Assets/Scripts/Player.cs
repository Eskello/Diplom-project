using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Player : MonoBehaviour
{
    private const string EndgamePanelName = "Popup_Endgame";

    [SerializeField] Rigidbody mainRigidbody;

    [SerializeField] float maxMoveSpeed;
    [SerializeField] [Range(0f, 1f)] float lerpSpeed;

    private InputSystem inputSystem;

    private float currentSpeed;
    private Vector3 moveDirection;

    private float XDirection = 0f;
    private float YDirection;
    private float ZDirection = 0f;

    private void Start()
    {
        inputSystem = FindObjectOfType<InputSystem>();
    }

    private void FixedUpdate()
    {
        MoveCart();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            var UIManager = FindObjectOfType<EFE_Base>();

            if (UIManager != null)
            {
                var endgamePanel = UIManager.FindPanel(EndgamePanelName);
                UIManager.OpenPanel(endgamePanel);
            }

            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


    private void MoveCart()
    {
        currentSpeed = mainRigidbody.velocity.x;
        YDirection = inputSystem.CartDirection;

        YDirection = Mathf.Lerp(currentSpeed, maxMoveSpeed * YDirection, lerpSpeed);

        moveDirection = new Vector3(YDirection, XDirection, ZDirection);

        mainRigidbody.velocity = moveDirection;
    }
}