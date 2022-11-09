using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderSystem : MonoBehaviour
{
    // Start is called before the first frame update
    //public Rigidbody projectile;
    //List<GameObject> Orders = new List<GameObject>();
    public List<string> Food;
    public List<string> Orders;

    void Start()
    {
        Orders = new List<string>();
        Food = new List<string> { "apple", "banana", "broccoli", "sodaCan", "sodaGlass", "meatCooked",  "pear", "pearHalf", "applehalf", 
                                  "coconutHalf", "cookedCarrot", "cookedCorn", "cookedFish", "gingerBread", "iceCream", "wholerHam"};

        InvokeRepeating("CreateOrder", 1.0f, 10.0f);

    }

    void CreateOrder()
    {
        int randomNum = Random.Range(0, Food.Count);
        string randomFood = Food[randomNum];
        Orders.Add(randomFood);
        GameObject.Find("First Person Controller").GetComponent<orderListUI>().orderListCopy(Orders);
        print("order added!");
        for(int i = 0; i < Orders.Count; i++)
        {
            print(Orders[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (string.Compare(col.gameObject.name, Orders[0]) == 0)
        {
            Orders.RemoveAt(0);
            GameObject.Find("First Person Controller").GetComponent<orderListUI>().orderListCopy(Orders);
            print("order completed!");
            GameObject.Find("First Person Controller").GetComponent<HighScoreScript>().AddHighScore();
            for (int i = 0; i < Orders.Count; i++)
            {
                print(Orders[i]);
            }
        }
        else
        {
            GameObject.Find("First Person Controller").GetComponent<strikeSystem>().AddStrike();
        }
        Destroy(col.gameObject);
    }

    void RemoveOrder()
    {

    }
}
