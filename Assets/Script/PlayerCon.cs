using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    [Header("�ړ��ݒ�")]
    [SerializeField, Tooltip("�v���C���[�̈ړ����x")]
    private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //���E����
        moveInput = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        //���E�����̑��x
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }
}
