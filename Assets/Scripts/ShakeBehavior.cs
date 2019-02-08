using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeBehavior : MonoBehaviour
{
    private Transform _transform;        // _transform desired game object (camera)
    private Vector3 _initialPosition;        // initial position of game object (camera)

    private float _shakeDuration;
    private float _shakeMagnitude;
    private float _dampingSpeed;

    private void Awake()
    {
        if (_transform == null)
            _transform = GetComponent(typeof(Transform)) as Transform;
    }

    void Start()
    {
        _initialPosition = _transform.localPosition;
    }

    void Update()
    {
        if (_shakeDuration > 0.0f)
        {
            _transform.localPosition = _initialPosition + Random.insideUnitSphere * _shakeMagnitude;
            _shakeDuration -= Time.deltaTime * _dampingSpeed;
        }
        else
        {
            _shakeDuration = 0.0f;
            _transform.localPosition = _initialPosition;
        }
    }

    public void TriggerShake()
    {
        _shakeDuration = 0.08f;
        _shakeMagnitude = 0.09f;  
        _dampingSpeed = 0.25f;
    }
}
