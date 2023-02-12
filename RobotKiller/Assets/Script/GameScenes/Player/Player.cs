using UnityEngine;

public class Player : MonoBehaviour
{
    


    [Header("явл€емс€ ли мы на земле?")]
    public bool Ground;

    public float _moveSpeed = 3f;
    private float _LRSpeed = 3f;

    public float vInput;
    public float xInput;

    public bool Tired = false;

    public float jumpVelocity = 2f;

    private Rigidbody _rb;

    public string labelText = "Killed 1 enemy to Win!";
    public float healthPlayer;
    public TargetPlayer targetplayer;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {   //Speed boost character 
        Move();

        targetplayer = GetComponent<TargetPlayer>();

        healthPlayer = targetplayer.PlayerHealth;
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (Ground == true)
            {
                _rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
            }

        }
    }
    
    void Move()
    {
        if (Tired == false)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                vInput = Input.GetAxis("Vertical") * _moveSpeed + 2f;
                xInput = Input.GetAxis("Horizontal") * _LRSpeed;
                this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
                this.transform.Translate(Vector3.left * -xInput * Time.deltaTime);

            }
            else if (!Input.GetKey(KeyCode.LeftShift))
            {
                vInput = Input.GetAxis("Vertical") * _moveSpeed;
                xInput = Input.GetAxis("Horizontal") * _LRSpeed;
                this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
                this.transform.Translate(Vector3.left * -xInput * Time.deltaTime);
            }
        }
        else if (Tired == true)
        {
            vInput = Input.GetAxis("Vertical") * _moveSpeed;
            xInput = Input.GetAxis("Horizontal") * _LRSpeed;
            this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
            this.transform.Translate(Vector3.left * -xInput * Time.deltaTime);
        }

        

       
    }

     void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "Player health: " + healthPlayer);
        
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);
    }




    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Ground = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Ground = false;
        }
    }
}
