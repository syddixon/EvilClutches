using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballs : MonoBehaviour
{
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(speed * Time.deltaTime * Vector3.right);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("I'm triggered!" + collision.name);
        Destroy(collision.gameObject); //destory object we hit
        Destroy(gameObject); //destroy fireball
    }
}
