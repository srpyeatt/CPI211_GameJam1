using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSodaCan : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject sodaCan;
    [SerializeField] private GameObject glassSoda;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(string.Compare(col.gameObject.name, "sodaCanCrushed") == 0)
        {
            Vector3 colPos = col.gameObject.transform.position;
            GameObject newFood = Instantiate(sodaCan, new Vector3(colPos.x, colPos.y, colPos.z), Quaternion.identity);
            newFood.name = newFood.name.Replace("(Clone)", "");
            Destroy(col.gameObject);
            Destroy(gameObject);
        }

        if (string.Compare(col.gameObject.name, "glass") == 0)
        {
            Vector3 colPos = col.gameObject.transform.position;
            GameObject newFood = Instantiate(glassSoda, new Vector3(colPos.x, colPos.y, colPos.z), Quaternion.identity);
            newFood.name = newFood.name.Replace("(Clone)", "");
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
