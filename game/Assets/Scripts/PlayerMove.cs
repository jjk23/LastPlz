using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMove : MonoBehaviour {
    public float MovePower = 1f;
    public float JumpPower = 3f;
    int collon = 1;
    Rigidbody2D RB;

    Vector3 movement;
    bool isJumping;

    IEnumerator wait ()
    {
        yield return new WaitForSeconds(1);
        startcoll();
    }
    void startcoll()
    {
        collon = 1;
    }
	// Use this for initialization
	void Start () {
        RB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if((Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.W))&&!isJumping)
        {
            Jump();
        }
        if(Springcamera.life == 0)
        {
            SceneManager.LoadScene("Gameover");
            Destroy(gameObject);
        }
	}

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {

        Vector3 moveVelocity = Vector3.zero;

        if(Input.GetAxis("Horizontal") < 0)
        {
            moveVelocity = Vector3.left;
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            moveVelocity = Vector3.right;
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }

        transform.position += moveVelocity * MovePower * Time.deltaTime;
    }
    void Jump()
    {
        if (isJumping)
            return;

        RB.velocity = Vector2.zero;

        Vector2 jumpVelocity = new Vector2(0, JumpPower);
        RB.AddForce(jumpVelocity, ForceMode2D.Impulse);

        isJumping = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Boss")
        {
            SceneManager.LoadScene("Ending");
        }
        if(collision.gameObject.tag == "ground")
        {
            isJumping = false;
        }
        if(collision.gameObject.tag == "gashi")
        {
            SceneManager.LoadScene("Gameover");
            Springcamera.life = 0;
            Destroy(gameObject);
        }
        if(collon == 1)
        {
            if(collision.gameObject.tag == "Trap")
            {
                Springcamera.life --;
                collon = 0;
                StartCoroutine("wait");
            }
        }
        
    }
}
