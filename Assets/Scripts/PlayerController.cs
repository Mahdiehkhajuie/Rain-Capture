using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField ] private  Rigidbody2D _rb;
    [SerializeField] private DropletBehaviour _dropletBehaviour;
    private float _speed = 10f;
    private float _inputHorizontal;


    private void Start()
    {
        _dropletBehaviour.SpawnDroplet();
    }



    void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");
        if (_inputHorizontal != 0)
        {
            _rb.AddForce(new Vector2(_inputHorizontal * _speed, 0f));
        }
    }
}
