using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _rotateSpeed = 700f;
    [SerializeField] private float _gravity = -9.8f;

    private CharacterController _characterController;
    private Vector3 _velocity;
    private bool _isGrounded;
    private bool _isRunning;

    public bool IsRunning
    {
        get => _isRunning;
    }


    private void Awake ()
    {
        _characterController = GetComponentInChildren<CharacterController>();
    }

    private void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        _isGrounded = _characterController.isGrounded;

        if ( movement.magnitude > 1 )
        {
            movement.Normalize();
        }

        _characterController.Move(movement * _moveSpeed * Time.deltaTime);


        if ( movement.magnitude > 0 )
        {
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, _rotateSpeed * Time.deltaTime);
        }

        if ( !_isGrounded )
        {
            _velocity.y += _gravity * Time.deltaTime;
        } 
        else
        {
            _velocity.y = 0;
        }

        _characterController.Move(_velocity * Time.deltaTime);

        _isRunning = (moveHorizontal != 0 || moveVertical != 0) ? true : (_characterController.velocity.magnitude == 0 ? false : _isRunning);

        Debug.Log(_isGrounded);
    }
}
