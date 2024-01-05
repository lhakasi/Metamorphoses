using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 130f;

    private void Update() =>    
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);    
}