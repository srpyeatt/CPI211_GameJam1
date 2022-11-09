using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class strikeSystem : MonoBehaviour
{

    public float strike = 0; 
    public Text strikeText;

    // Update is called once per frame
    void Update()
    {
        if (strikeText.name == "strikeText") {
            strikeText.text = "Strikes: " + strike;
        }
        if (Input.GetKey("escape")) {
            Application.Quit();
        }
        if (strike >= 3) {
            SceneManager.LoadScene("gameOver");
        }
    }

    void OnCollisionEnter(Collision col) {
        if (string.Compare(col.gameObject.tag, "enemy") == 0) {
            strike++;
            Debug.Log("Trigger by Enemy");
            Destroy(col.gameObject);
        }
    }

    public void AddStrike()
    {
        strike++;
        Debug.Log("Trigger by Wrong Order");
    }
}