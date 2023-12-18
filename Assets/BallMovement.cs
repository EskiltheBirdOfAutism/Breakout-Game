using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    public Rigidbody rb;

    public GameObject camera_object;
    public float speed;
    private void Start()
    {
        if (Random.Range(1,4) > 2)
        { 
            rb.AddForce(20f, -100f, 0f);
        }
        else
        {
            rb.AddForce(-20f, -100f, 0f);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = rb.velocity.normalized * speed;

        if(transform.position.y < -10f)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
       camera_object.GetComponent<Shake>().shake = 1f;
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 pos = collision.gameObject.transform.position;

        rb.velocity = new Vector3(rb.velocity.x, -rb.velocity.y, rb.velocity.z);

        if (collision.collider.tag == "Player")
        {
            if (pos.x < transform.position.x)
            {
                rb.velocity = new Vector3(-2f, rb.velocity.y, rb.velocity.z);
            }
            else
            {
                rb.velocity = new Vector3(2f, rb.velocity.y, rb.velocity.z);
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y-0.1f, transform.position.z);
        }
    }
    */
}
