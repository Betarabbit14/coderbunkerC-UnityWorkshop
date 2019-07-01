using UnityEngine;

public class ItemScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        spawnGem();
    }

    private void spawnGem()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D   (Collider2D col)
    {
        Debug.Log("Collided!");
        if (col.tag.Contains("player"))
        {
            Destroy(gameObject);
            Debug.Log("Gem Collected!");
            gameControllerScript.winCounter++;
            //Destroy(GetComponent<BoxCollider2D>());
            //Destroy(GetComponent<SpriteRenderer>());
        }
    }
}
