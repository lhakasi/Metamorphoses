using UnityEngine;

public class MovingForward : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;

    private void Update() =>    
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);    
}