using UnityEngine;

public class MovingUp : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;

    private void Update() =>
        transform.Translate(Vector3.up * _moveSpeed * Time.deltaTime);
}