using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private AudioSource enemyHitSound;

   [SerializeField] private float damage = 20f;
   private AttackControler _attackControler;
   private void Start(){
       _attackControler = transform.root.GetComponent<AttackControler>();
   }

   private void OnTriggerEnter2D(Collider2D other) {
       EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
       if(enemyHealth != null && _attackControler.IsAttack){
       enemyHealth.ReduceHealth(damage);
       enemyHitSound.Play();
   }
       
           
       
   }

}
