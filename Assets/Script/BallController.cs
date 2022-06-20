using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{


    [SerializeField] float _speed = default;
    [SerializeField] Transform m_player = default;
    [SerializeField] GameObject _player;
    Animator _animator;
    Rigidbody2D _rb;
    SpriteRenderer _sr;
    //AudioSource _as;
    BallAudio _ba;
    bool _hittingCheck;
    float _random = default;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, -45));
        //Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //rb.velocity = this.transform.up * _speed;
        transform.position = m_player.position;
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
        _ba = GetComponent<BallAudio>();
        //_as = GetComponent<AudioSource>();
        //_hittingCheck = true;
        _animator = _player.GetComponent<Animator>();
        _animator.SetBool("New Bool", false);
    }

    public void CheckOn()
    {
        _hittingCheck = true;
        Debug.Log("CheckOnÇ™Ç§Ç≤Ç¢ÇƒÇÈÇÊ");
    }

    public void CreanHit()
    {

        _random = Random.Range(0.65f, 1.0f);
        //_hittingCheck = false;

    }

    public void Hit()
    {


        _random = Random.Range(0.3f, 0.65f);
        //_hittingCheck = false;

    }

    public void Bad()
    {

        _random = Random.Range(0.01f, 0.3f);


    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && _hittingCheck)
        {
            /*_rb.velocity = this.transform.up *_speed * _random;
            _hittingCheck = false;*/
            StartCoroutine("Later");
        }
    }


    public void CheckOff()
    {
        _hittingCheck = false;
        Debug.Log("CheckoffÇ™ìÆÇ¢ÇƒÇÈÇÊ");
    }

    IEnumerator Later()
    {
        _animator.SetBool("New Bool", true);
        _ba.AtBat();

        yield return null;  // Ç±Ç±Ç≈ñ{óàÇÕ PitchingBall Çè¡ÇµÇΩï˚Ç™ó«Ç¢
        _sr.color = Color.white;
        _rb.velocity = this.transform.up * _speed * _random;
        _hittingCheck = false;
    }
}
