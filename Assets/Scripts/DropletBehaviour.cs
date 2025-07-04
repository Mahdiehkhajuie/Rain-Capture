using UnityEngine;

public class DropletBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    public void SpawnDroplet()
    {
        Instantiate(_prefab, new Vector3(Random.Range(-8f, 8f), 9f, 0), Quaternion.identity );
    }



    private void OnCollisionEnter2D(Collision2D other )
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.TakeDamage(1); // کم کردن سلامتی
            GameManager.Instance.AddScore(1);  // افزایش امتیاز 
           SpawnDroplet();
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Ground"))
        {
            GameManager.Instance.MissedDrop();
            Destroy(gameObject);
        }
    
    }
}
