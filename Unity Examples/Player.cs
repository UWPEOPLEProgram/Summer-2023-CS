using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //1 Note: Numbers corresponded with class notes and were for organization
    public float speed;
    private Rigidbody2D rb;

    //3
    public float jumpHeight;

    //4
    private bool isGrounded;
    [SerializeField] private LayerMask groundLayer;
    private CircleCollider2D collider;

    //8
    public GameObject projectile;
    [SerializeField] private KeyCode shootKey;

    
    // Start is called before the first frame update
    void Start()
    {
        //1
        rb = GetComponent<Rigidbody2D>();

        //4
        collider = GetComponent<CircleCollider2D>();


    }

    // Update is called once per frame
    void Update()
    {

        //1
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);

        //2
        if(Input.GetKeyDown(KeyCode.Space) && checkGround())
        {
            //2
            Debug.Log("Jump");

            //3
            rb.AddForce(new Vector2(rb.velocity.x, jumpHeight), ForceMode2D.Impulse);
        }

        if(Input.GetKeyDown(shootKey))
        {
            GameObject fired = Instantiate(projectile, transform.position, transform.rotation);
            
        }

    }

    //4
    private bool checkGround()
    {
        RaycastHit2D raycastHit = Physics2D.Raycast(collider.bounds.center, Vector2.down, collider.bounds.extents.y + 0.05f, groundLayer);
        return raycastHit.collider != null;
    }

    //5
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            GameManager.AddPoints(1);
            Debug.Log("Got Coin, Points: " + GameManager.GetPoints());
        }
    }
}
