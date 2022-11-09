using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject applehalf;
    [SerializeField] private GameObject pearhalf;
    [SerializeField] private GameObject coconuthalf;
    [SerializeField] private GameObject meatRaw;
    [SerializeField] private GameObject wholeHam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(string.Compare(col.gameObject.name, "apple") == 0)
        {
            Slice(applehalf, applehalf, col);
        }

        if (string.Compare(col.gameObject.name, "coconut") == 0)
        {
            Slice(coconuthalf, coconuthalf, col);
        }

        if (string.Compare(col.gameObject.name, "pear") == 0)
        {
            Slice(pearhalf, pearhalf, col);
        }

        if (string.Compare(col.gameObject.name, "wholerHam") == 0)
        {
            Slice(wholeHam, meatRaw, col);
        }

        Destroy(gameObject);
    }

    void Slice(GameObject x, GameObject y, Collision col)
    {
        Vector3 colPos = col.gameObject.transform.position;
        GameObject newFood = Instantiate(x, new Vector3(colPos.x, colPos.y, colPos.z), Quaternion.identity);
        newFood.name = newFood.name.Replace("(Clone)", "");
        GameObject newFoodSecond = Instantiate(y, new Vector3(colPos.x, colPos.y, colPos.z), Quaternion.identity);
        newFoodSecond.name = newFoodSecond.name.Replace("(Clone)", "");
        Destroy(col.gameObject);
    }
}
