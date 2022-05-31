using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] float _speed = default;
    [SerializeField] Transform m_player = default;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, -45));
        //Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //rb.velocity = this.transform.up * _speed;
       transform.position = m_player.position;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = this.transform.up *_speed * Random.value;
        }
    }
}
