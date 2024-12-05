using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    [SerializeField] TableLayoutData tableLayout;
    [SerializeField] StudentData[] students;
    [SerializeField] GameObject tablePrefab;
    [SerializeField] GameObject chair;

    // Start is called before the first frame update
    private void Start()
    {
        for(int row = 0; row < tableLayout.rows; row++)
        {
            for(int col = 0; col < tableLayout.columns; col++)
            {
                Vector3 tablePosition = new Vector3(col * tableLayout.tableSpacing, 0, row * tableLayout.tableSpacing);
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform);
                Debug.Log("x:" + (col * tableLayout.tableSpacing));
               
            }
            
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
