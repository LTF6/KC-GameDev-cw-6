using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Move : MonoBehaviour
{
    // Score 
    public float Score;

    // Ui Score
    public TextMeshProUGUI winText;
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.z <= 13f) /* limit is z -12.5 */ {
            transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 0.3f);
        } if (Input.GetKey(KeyCode.A) && transform.position.x >= -4.2f) /* limit is x -4.2 */ {
            transform.position = new Vector3(transform.position.x - 0.3f, transform.position.y, transform.position.z);
        } if (Input.GetKey(KeyCode.S) && transform.position.z >= -12.5f) /* limit is z -12.5 */ {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.3f);
        } if (Input.GetKey(KeyCode.D) && transform.position.x <= 4.25f) /* limit is x 4.25 */ {
            transform.position = new Vector3(transform.position.x + 0.3f, transform.position.y, transform.position.z);
        } if (Input.GetKey(KeyCode.Space) && transform.position.y >= 0) {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
        }
     // return the ball to main pos glitch fix
        if (transform.position.z < -12.5) {
            SceneManager.LoadScene(0);
        } else if (transform.position.z >= 13f && Score == 0)
        {
            Destroy(this.gameObject);
            winText.text = "You Win btw !!!!!";
        }

    
    }

    

}
