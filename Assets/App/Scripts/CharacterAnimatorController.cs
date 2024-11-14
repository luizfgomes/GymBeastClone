using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimatorController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private CharacterMovement _characterMovement;

    private void Awake ()
    {
        _animator = GetComponentInChildren<Animator>();
        _characterMovement = GetComponent<CharacterMovement>();
    }

    private void LateUpdate ()
    {
        _animator.SetBool("Run", _characterMovement.IsRunning);
    }
}
