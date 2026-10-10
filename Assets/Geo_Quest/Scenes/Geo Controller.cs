using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public int speed = 3;
    public string NextLevel = "Level 2";
    private Renderer playerRenderer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerRenderer = GetComponent<Renderer>();
    }
    public void SetPlayerColor(Color newColor)
    {
        if (playerRenderer != null)
        {
            // Change the main color property of the material
            playerRenderer.material.color = newColor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        {
            float xInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(xInput*speed, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetPlayerColor(Color.red);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetPlayerColor(Color.blue);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetPlayerColor(Color.green);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(NextLevel);
                    break;
                }
        }
    }
}
/*
   int Number = 3;
   Debug.Log(Number);
   Number++;
   if (Input.GetKey(KeyCode.W))
   {
       transform.position += new Vector3(0, 1, 0);
   }
   if (Input.GetKey(KeyCode.S))
   {
       transform.position += new Vector3(0, -1, 0);
   }
   if (Input.GetKey(KeyCode.A))
   {
       transform.position += new Vector3(-1, 0, 0);
   }
   if (Input.GetKey(KeyCode.D))
   {
       transform.position += new Vector3(1, 0, 0);
   }
if (Input.GetKey(KeyCode.A))
   {
       rb.velocity = new Vector2(-1, rb.velocity.y);
   }
   if (Input.GetKey(KeyCode.D))
   {
       rb.velocity = new Vector2(1, rb.velocity.y);
   }
   Debug.Log("Hit");
    string Var2 = "Hello";
    Debug.Log(Var2 + " World");
*/