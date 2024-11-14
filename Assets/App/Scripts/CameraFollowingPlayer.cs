using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowingPlayer : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;
    [Range(0.1f, 0.2f)]private float _smoothSpeed = 100f;

    private void LateUpdate ()
    {
        if( _target != null )
        {
            Vector3 desiredPosition = _target.position + _offset;

            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, _smoothSpeed);

            transform.position = smoothedPosition;

            transform.LookAt(_target);
        }
    }
}
