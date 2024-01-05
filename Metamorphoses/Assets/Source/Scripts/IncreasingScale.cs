using UnityEngine;

public class IncreasingScale : MonoBehaviour
{
    [SerializeField] private float scaleSpeed = 0.1f;

    private void Update() =>
        transform.localScale += new Vector3(scaleSpeed, scaleSpeed, scaleSpeed) * Time.deltaTime;
}