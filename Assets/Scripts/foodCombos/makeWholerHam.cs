using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeWholerHam : MonoBehaviour
{
    [SerializeField] private GameObject wholerHam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (string.Compare(col.gameObject.name, "mysteryMeat") == 0)
        {
            Vector3 colPos = col.gameObject.transform.position;
            GameObject newFood = Instantiate(wholerHam, new Vector3(colPos.x, colPos.y, colPos.z), Quaternion.identity);
            newFood.name = newFood.name.Replace("(Clone)", "");
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
