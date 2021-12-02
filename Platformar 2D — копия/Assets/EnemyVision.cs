using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    [SerializeField] private GameObject currentHitObject;
    [SerializeField] private float circleRadius;
    [SerializeField] private float maxDistance;
    [SerializeField] private LayerMask layerMask;

    private EnemyControler _enemyControler;

    private Vector2 _origin;
    private Vector2 _direction;
    private float _currentHitDistance;
    private void Start(){
        _enemyControler = GetComponent<EnemyControler>();
    }
    private void Update(){
        _origin = transform.position;
        if(_enemyControler.IsFacingRight) {
            _direction = Vector2.right;

        }else {
            _direction = Vector2.left;
        }
        
        RaycastHit2D hit = Physics2D.CircleCast(_origin, circleRadius, _direction, maxDistance, layerMask);
        if(hit){
            currentHitObject = hit.transform.gameObject;
            _currentHitDistance = hit.distance;
            if(currentHitObject.CompareTag("Player")){
                _enemyControler.StartChasingPlayer();

            }
        }else {
            currentHitObject = null;
            _currentHitDistance = maxDistance;
        }
    }
    private void OnDrawGizmos(){
        Gizmos.color = Color.red;
        Gizmos.DrawLine(_origin, _origin + _direction * _currentHitDistance);
        Gizmos.DrawWireSphere(_origin + _direction * _currentHitDistance, circleRadius);
    }
}
