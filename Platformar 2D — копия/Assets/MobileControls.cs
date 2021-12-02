using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileControls : MonoBehaviour
{
    private AttackControler _attackControler;
    private PlayerControler _playerControler;
    void Start(){
        
        _attackControler = GameObject.FindGameObjectWithTag("Player").GetComponent<AttackControler>();
        _playerControler = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControler>();

    }
    
    

    public void Attack(){
        _attackControler.Attack();
    }
    public void Jump(){
        _playerControler.Jump();

    }
    public void Interact(){
        _playerControler.Interact();
    }
}
