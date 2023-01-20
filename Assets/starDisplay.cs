using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class starDisplay : MonoBehaviour
{
    private Text starText;
    private int stars = 40;
    public enum status{SUCCESS, FAIL};
    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addStar(int amount)
    {
        stars += amount;
        UpdateDisplay();
         //print("stars added to display " + amount);
    }
    public status useStar(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
            return status.SUCCESS;
        }
        else
        {
            return status.FAIL;
        }
        
    }
    public void UpdateDisplay()
    {
        starText.text = "Amount : " + stars.ToString(); 
    }
}
