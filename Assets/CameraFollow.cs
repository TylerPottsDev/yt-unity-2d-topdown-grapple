using UnityEngine;

public class CameraFollow : MonoBehaviour {
    [SerializeField] Transform target;

    private void LateUpdate() {
        transform.position = target.position;
    }
}
