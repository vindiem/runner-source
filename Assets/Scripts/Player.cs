using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;


    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 3;

    public GameObject effect;

    //public GameObject startPos;

    public Text healthDisplay;

    public GameObject panel;

    private Animator camAnim;

    private void Start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }

    private void Update()
    {
        healthDisplay.text = health.ToString();

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight )
        {
            camAnim.SetTrigger("shake");
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            Instantiate(effect, transform.position, Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight )
        {
            camAnim.SetTrigger("shake");
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            Instantiate(effect, transform.position, Quaternion.identity);
        }

        else if (transform.position.y >= maxHeight)
        {

        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("menu");
        }


        if (health <= 0)
        {
            panel.SetActive(true);
            Destroy(gameObject);
        }
    }


}
