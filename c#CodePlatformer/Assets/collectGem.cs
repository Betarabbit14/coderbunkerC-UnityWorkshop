using UnityEngine;

public class collectGem : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "gem")
        {
            gameControllerScript.winCounter += 1;
            Destroy(col.gameObject);
        }
    }
}
