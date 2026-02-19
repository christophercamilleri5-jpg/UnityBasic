using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private int health = 100;
    public float speed = 10.5f;
    public float rotation_speed = 90;
    public string player_name = "Billy";
    public bool alive = true;
    public double score = 0.1;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Hello, my name is {player_name}"); // debug is like console.log/print
        
    }

    // Update is called once per frame
    void Update()
    {
        //No direction or rotation when the frame starts 
        Vector3 direction = Vector3.zero;

        float rotation_angle = 0f;

        if (Keyboard.current.wKey.isPressed)
        {
            direction.y = 1;
        } else if (Keyboard.current.sKey.isPressed)
        {
            direction.y = -1;
        } else if (Keyboard.current.aKey.isPressed)
        {
            direction.x = -1;
        }else if (Keyboard.current.dKey.isPressed)
        {
            
            direction.x = 1;
        }
        
        //left/right rotation

        if (Keyboard.current.aKey.isPressed)
        {
            rotation_angle = -1;
        }else if (Keyboard.current.dKey.isPressed)
        {
            rotation_angle = 1;
        }
        
        
        transform.Translate(direction * Time.deltaTime * speed);
        transform.Rotate(Vector3.back * rotation_angle * rotation_speed * Time.deltaTime);
       
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //Time.deltaTime -> the time between two frames
        
    }
}
