using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// House code
/// </summary>
public class House : MonoBehaviour
{
    private float X = 0;
    private float Y = 0;

    public House(float x, float y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Draw(GameObject houseModel)
    {
        GameObject houseClone = Instantiate(houseModel);
        houseClone.transform.position = new Vector3(X, Y, 0);
    }
}

/// <summary>
/// Village code
/// </summary>
public class Village : MonoBehaviour
{
    public House[] houses;

    private float X;
    private float Y;

    public Village(int houseNum, float x, float y)
    {
        houses = new House[houseNum];
        this.X = x;
        this.Y = y;

        for (int i = 0; i < houseNum; i++)
        {
            float houseX = x + Random.Range(-7f, 7f);
            float houseY = y + Random.Range(-7f, 7f);
            houses[i] = new House(houseX, houseY);
        }
    }

    public void Draw(GameObject houseModel)
    {
        for (int i = 0; i < houses.Length; i++)
        {
            houses[i].Draw(houseModel);
        }
    }






    /*private void draw(GameObject village)
    {
        Instantiate(village);
    }*/
}

/// <summary>
/// Township code
/// </summary>
public class Township : MonoBehaviour
{

    /*float X = x;
    float Y = y;*/

    public GameObject houseModel;
    private Village[] villages;

    // Start is called before the first frame update
    void Start()
    {
        villages = new Village[3];

        for (int i = 0; i < villages.Length; i++)
        {
            int houseNum = Random.Range(2, 6);
            float villageX = Random.Range(-1f, 1f);
            float villageY = Random.Range(-1f, 1f);
            villages[i] = new Village(houseNum, villageX, villageY);
        }

        for (int i = 0; i < villages.Length; i++)
        {
            villages[i].Draw(houseModel);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}