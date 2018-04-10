using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    public int scoreValue;
    private GameController gameController;

    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null) // Om gameControllerObject existerar.
        {
            gameController = gameControllerObject.GetComponent<GameController>(); // Hämta Object GameController.
        }
        if (gameController == null) // Om gameController inte existerar.
        {
            Debug.Log ("Cannot find 'GameController' script"); // Logga att gameController inte existerar.
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Boundary") || other.CompareTag ("Enemy")) // Om Collidern har en Tag av Boundary eller Enemy, ignorera och gå tillbaka.
        {
            return;
        }

        if (explosion != null) // Om explosion existerar.
        {
            Instantiate(explosion, transform.position, transform.rotation); // Insantiera en Explosion på transformens position och rotation.
        }
        if (other.tag == "Player") { // Om Collidern har en Tag av Player.
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation); // Instantiera en Playerexplosion på Objektet med taggen Player och aktivera GameOver.
            gameController.GameOver();
        }
        gameController.AddScore(scoreValue); // Lägg till obektets poängvärde.
        Destroy(other.gameObject); // Förstör objektet som nuddade detta objekt.
        Destroy(gameObject); // Förstör detta objekt.
    }
}
