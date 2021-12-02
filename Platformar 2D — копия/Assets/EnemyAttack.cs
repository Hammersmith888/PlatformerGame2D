using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
   [SerializeField] private float damage = 20f;
   [SerializeField] private float timerToDamage = 1f;
   private float _damageTime;
   private bool _isDamage = true;
   private void Start(){
       _damageTime = timerToDamage;

   }
   private void Update(){
       if(_isDamage){
           _damageTime -= Time.deltaTime;
           if (_damageTime <= 0){
               _isDamage = true;
               _damageTime = timerToDamage;

           }
       }
   }
   private void OnCollisionStay2D(Collision2D other){
       PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();

       if(playerHealth != null && _isDamage) {
           playerHealth.ReduceHealth(damage);
           _isDamage = false;
       }
   }
}
