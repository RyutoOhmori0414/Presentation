using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool _judge = default;
    //float m_h = default;
    //Vector3 rotation = default;
    [SerializeField] GameObject m_ballPrefab = default;
    // Start is called before the first frame update
    void Start()
    {
        _judge = true;
    }

    // Update is called once per frame
    void Update()
    {
        //m_h += Input.GetAxisRaw("Horizontal");

        //rotation = transform.eulerAngles;
        //rotation.z += m_h * 10f;
        //transform.Rotate(new Vector3(0, 0, m_h));




        /*if (Input.GetButtonDown("Jump") && _judge)
        {
            Instantiate(m_ballPrefab);
            _judge = false;
        }*/
    }
}
