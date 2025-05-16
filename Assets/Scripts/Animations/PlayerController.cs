using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        var Mahdieh = Input.GetAxis("Horizontal");
        var force = new Vector2(Mahdieh, 0);
        rb.AddForce(force /3,ForceMode2D.Impulse);
    }
       private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("WALL"))
        {
            Debug.Log("THIS IS THE WALL");
        }
    }
}
