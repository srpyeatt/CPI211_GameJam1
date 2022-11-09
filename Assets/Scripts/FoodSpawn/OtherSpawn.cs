using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherSpawn : MonoBehaviour
{
    private List<int> otherList;
    [SerializeField] GameObject gingerBread;
    [SerializeField] GameObject gingerBreadCutter;
    [SerializeField] GameObject glass;
    [SerializeField] GameObject iceCream;
    [SerializeField] GameObject sodaBottle;
    [SerializeField] GameObject sodaCanCrushed;
    private GameObject newFood;


    // Start is called before the first frame update
    void Start()
    {
        otherList = new List<int> { 0, 1, 2, 3, 4, 5};
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        int randomNum = Random.Range(0, otherList.Count);
        int randomOther = otherList[randomNum];

        switch (randomOther)
        {
            case 0:
                newFood = Instantiate(gingerBread, new Vector3(9, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 1:
                newFood = Instantiate(gingerBreadCutter, new Vector3(9, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 2:
                newFood = Instantiate(glass, new Vector3(9, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 3:
                newFood = Instantiate(iceCream, new Vector3(9, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 4:
                newFood = Instantiate(sodaBottle, new Vector3(9, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 5:
                newFood = Instantiate(sodaCanCrushed, new Vector3(9, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            default: break;
        }

    }
}
