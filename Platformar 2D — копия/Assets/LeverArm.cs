using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverArm : MonoBehaviour
{
    private Finish _finish;
    private Animator _animator;

    void Start(){
        _animator = GetComponent<Animator>();
        _finish = GameObject.FindGameObjectWithTag("Finish").GetComponent<Finish>();
    }

    public void ActivateLeverArm(){
        _animator.SetTrigger("activate");
        _finish.Activate();
    }
}
