using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player InstPlayer;

    public float jumpForce = 10f;

    public Rigidbody2D rb;
    public SpriteRenderer sr;

    public string currentColor;

    public int Score;

    public Color colorCyan;
    public Color colorYellow;
    public Color colorPink;
    public Color colorPurple;

    void Start() {
        SetRandomColor();    
    }

    private void Awake() {
        InstPlayer = this;
    }

    void Update() {

        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))  {

            rb.velocity = Vector2.up * jumpForce;   

        } 
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        //Cor
        if (col.tag == "ColorChanger") {
            SetRandomColor();
            Destroy(col.gameObject);
            return;

        }

        //Game Over
        if (col.tag != currentColor) {
            Debug.Log("Game Over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (col.tag == "GameOver") {
            Debug.Log("Game Over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        //Score
        if (col.tag == "Purple" && currentColor == "Purple") {
            Score++;
        }

        if (col.tag == "Pink" && currentColor == "Pink") {
            Score++;
        }

        if (col.tag == "Cyan" && currentColor == "Cyan") {
            Score++;
        }

        if (col.tag == "Yellow" && currentColor == "Yellow") {
            Score++;
        }


    }

    private void SetRandomColor() {
        int index = Random.Range(0,4);

        switch (index) { 
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;
                break;

            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;

            case 2:
                currentColor = "Purple";
                sr.color = colorPurple;
                break;

            case 3:
                currentColor = "Pink";
                sr.color = colorPink;
                break;
                

        }  
        
    }
}
