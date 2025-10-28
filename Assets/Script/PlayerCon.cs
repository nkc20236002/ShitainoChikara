using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    [Header("移動設定")]
    [SerializeField, Tooltip("プレイヤーの移動速度")]
    private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //左右入力
        moveInput = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        //左右方向の速度
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }
}
