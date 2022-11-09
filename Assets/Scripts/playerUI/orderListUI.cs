using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class orderListUI : MonoBehaviour
{
    public Text orderText;
    public List<string> OrdersListText;
    private string orderList;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void orderListCopy(List<string> list)
    {
       orderList = "";
       OrdersListText = list;

        for (int i = 0; i < OrdersListText.Count; i++)
        {
            orderList += OrdersListText[i] + "\n";
        }

        orderText.text = orderList;
    }
}
