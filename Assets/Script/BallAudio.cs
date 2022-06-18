using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAudio : MonoBehaviour
{
    [SerializeField] AudioSource _batas;
    [SerializeField] AudioSource _shougekias;

    [SerializeField] AudioClip _bat;
    [SerializeField] AudioClip _shougeki;

    //AudioSource _as;
    private void Start()
    {
        //_as = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    public void AtBat()
    {
        _batas.PlayOneShot(_bat);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _shougekias.PlayOneShot(_shougeki);
    }
}
