using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchBallController : MonoBehaviour
{
    public BallController ballcontroller;
    [SerializeField] float _speed = 5;
    Rigidbody2D _rb;
    SpriteRenderer _rd;
    float _DTime = default;
    GameObject _a;
    BallController _bc;
    bool _ec = default;
    //[SerializeField] GameObject 
    

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rd = GetComponent<SpriteRenderer>();
        _rb.velocity = this.transform.right * _speed /* * Random.value*/ * -1;
        _a = GameObject.Find("BattingBall");
        _bc = _a.GetComponent<BallController>();
        _ec = true;
    }

    private void Update()
    {
        _DTime = Time.deltaTime;
        if (Input.GetButtonDown("Jump"))
        {
            _ec = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _bc.CheckOn();
        Debug.Log("CheckOn����΂ꂽ��");

        if (collision.gameObject.tag == "CleanHit" && _ec)
        {
             _bc.CreanHit();
            Debug.Log("CleanHit���Ă΂���");
        }
        else if (collision.gameObject.tag == "Hit" && _ec)
        {
             _bc.Hit();
            Debug.Log("Hit���Ă΂���");
        }
        else if (collision.gameObject.tag == "Bad" && _ec)
        {
            _bc.Bad();
            Debug.Log("Bad���Ă΂���");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bad")
        {
            _bc.CheckOff();
            Debug.Log("CheckOff���Ă΂ꂽ��");
        }
    }
    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Jump"))
        {
            //Destroy(this.gameObject);
            _rd.color = Color.clear;
        }

        
    }

}
