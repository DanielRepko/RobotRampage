using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 30f;
    public int damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        // executes the DeathTimer coroutine
        StartCoroutine("DeathTimer");
    }

    // Update is called once per frame
    void Update()
    {
        //moving the missile forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    //destroys the missile after 10 seconds
    IEnumerator DeathTimer()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }

    //adding this otherwise the missle start bouncing off of the walls until they despawn
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
