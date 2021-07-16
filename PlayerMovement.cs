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

                Debug.Log("Must, Now, Poor, Cruel, Wonderful, Better, Us, Soon, Could, Would, Should, Maybe, Certain, Deppressing, Uplifting, Bright, We");

                /* 
                 
                 
                 The speaker used words such  as poor turtles(p) and now(k/hm) 
                Facts
                Emotive Language
                Meataphors
                Killing Anima;s
                Ethos Credibility from countries
                Theories
                High Modality
                Informative
                Rhetorical Questions
                It Hurts Marine Life
                relate to real life situationse
                they dont degrade
                ends up in marine life
                 
                 
                 
                 
                 */
             
                // Peer Paragraph

                /* 
                    Plastic Straws are dangerous to the environment because plastic does not degrade -- fact. Most straws get thrown into the ocean which sadly -- emotive pathos, ends up in marine life --fact . These plastic straws get stuck up the nose of poor turtles -- emotive pathos. Another reason why we -- inclusive should drop the plastic straw is because there are alternatives similar to milk which has plant based milks which are disgusting -- the most true thing which is why you should drink skim, full cream or lactose free, there are non-plastic straws such as metal, paper, and bamboo. The third reason you should start using non plastic straws is the fact that the plastic that the fish sea creatures eat stay in their stomach which means that when we catch them, we are also eating the plastic they eat. Crazy right! With all this information said and done, i hope you decide to drop the plastic straw now! -- high modality
                 
                */
            }
        }
    }
    
    IEnumerator delay() {
        print("Debounce");
        yield return new WaitForSeconds(2);
        jumpCooldown = 0;
    }

}
