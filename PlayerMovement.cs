using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D body;
    [SerializeField] public float speed;
    [SerializeField] public float jumpCooldown = 0;
    [SerializeField] public float jumpheight = 4;

    void Awake() {
        body = GetComponent<Rigidbody2D>();


        body.transform.position = new Vector2(-10, 1);
    }

    void Update () {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space)) {
            if (jumpCooldown == 0) {
                body.velocity = new Vector2(body.velocity.x, jumpheight);
                jumpCooldown = 1;
                StartCoroutine(delay());
            }
        }
    }
    
    IEnumerator delay() {
        print("Debounce");
        yield return new WaitForSeconds(2);
        jumpCooldown = 0;
    }

}
