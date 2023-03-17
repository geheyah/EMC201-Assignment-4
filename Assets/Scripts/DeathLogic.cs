using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Debug.Log("You died!");
                SceneManager.LoadScene("DeathUI");
                /*  IEnumerator WaitUntil((CoolDown)= 3f); //a coroutine gives a cooldown before the next line is executed
                  SceneManager.LoadScene("Level"); */
            }
        }
    }
}
