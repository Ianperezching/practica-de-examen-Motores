using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    private Rigidbody2D myRB;
    [SerializeField]
    private float speed;
    private float limitSuperior;
    private float limitInferior;
    public int player_lives = 4;
    // Start is called before the first frame update
    public void Awake()
    {
        myRB = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        SetMinMax();
        if (up == KeyCode.None) up = KeyCode.UpArrow;
        if (down == KeyCode.None) down = KeyCode.DownArrow;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetMinMax()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        limitInferior = -bounds.y;
        limitSuperior = bounds.y;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Candy")
        {
            CandyGenerator.instance.ManageCandy(other.gameObject.GetComponent<CandyController>(), this);
        }
    }
    public void Movimiento(InputAction.CallbackContext context)
    {
        
        float moveInput = context.ReadValue<Vector2>().y;

      
        myRB.velocity = new Vector2(0f, moveInput * speed);
    }
}
