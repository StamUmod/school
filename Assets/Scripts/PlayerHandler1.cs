using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class PlayerHandler1 : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rigidbody2D;
    public AudioSource jumpSound; // 新增 AudioSource 變數

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        jumpSound = GetComponent<AudioSource>(); // 取得 AudioSource 元件
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.velocity = new Vector2(-5, rigidbody2D.velocity.y);
            transform.localScale = new Vector2(-1, 1);
            animator.SetBool("女主", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.velocity = new Vector2(5, rigidbody2D.velocity.y);
            transform.localScale = new Vector2(1, 1);
            animator.SetBool("女主", true);
        }
        else
        {
            animator.SetBool("女主", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, 10.0f);
            PlayJumpSound(); // 在跳躍時播放音效
        }
    }

    void PlayJumpSound()
    {
        // 檢查是否有 AudioSource 元件和跳躍音效設定
        if (jumpSound != null && jumpSound.clip != null)
        {
            // 播放跳躍音效
            jumpSound.PlayOneShot(jumpSound.clip);
        }
    }
}