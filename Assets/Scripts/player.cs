using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpForce = 5f;

    bool colision;

    // Start is called before the first frame update
    void Start()
    {
        colision = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += movement * moveSpeed * Time.deltaTime;
        Jump();
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && colision)
        {
            colision = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    public void Die()
    {
        transform.position = new Vector3(-6, 3, 0);
        SceneManager.LoadScene("Game");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        colision = true;
    }
}
