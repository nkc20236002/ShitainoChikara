using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("追尾対象")]
    [SerializeField] private Transform target;

    [Header("追尾速度")]
    [SerializeField] private float smoothSpeed = 5f;

    [Header("カメラ位置オフセット")]
    [SerializeField] private Vector3 offset;

    private void LateUpdate()
    {
        FollowTarget();
    }

    //プレイヤー追尾
    private void FollowTarget()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;

        // Z軸は今のカメラ位置を維持
        desiredPosition.z = transform.position.z;

        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
    }
}
