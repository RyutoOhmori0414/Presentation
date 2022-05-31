// 日本語対応
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    [SerializeField] float _stopTimer = 1f;
    [SerializeField] float _stopSpeed = 0.2f;
    float _timer = 0f;
    Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if (_rb.velocity.magnitude < _stopSpeed && _rb.velocity.magnitude > 0)
        {
            _timer += Time.deltaTime;

            if (_timer > _stopTimer)
            {
                Debug.Log("Stop");
                _rb.velocity = Vector3.zero;
                _rb.Sleep();
                _timer = 0f;
            }
        }
        else
        {
            _timer = 0;
        }
    }
}
