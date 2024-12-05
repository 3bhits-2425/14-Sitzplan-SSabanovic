using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    [SerializeField] TableLayoutData tableLayout;
    [SerializeField] StudentData[] students;
    [SerializeField] GameObject tablePrefab;
    [SerializeField] GameObject chairPrefab;

    // Start is called before the first frame update
    private void Start()
    {
        for (int row = 0; row < tableLayout.rows; row++)
        {
            for (int col = 0; col < tableLayout.columns; col++)
            {
                Vector3 tablePosition = new Vector3(col * tableLayout.tableSpacing, 0, row * tableLayout.tableSpacing);
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform);
                Debug.Log("x:" + (col * tableLayout.tableSpacing));

                //Sessel platzieren
                Transform pos1 = table.transform.Find("pos1");
                Transform pos2 = table.transform.Find("pos2");

                if (pos1)
                {
                    Debug.Log("pos1 gefunden: " + pos1.position);
                    Instantiate(chairPrefab, pos1.position, pos1.rotation, table.transform);
                }
                else
                {
                    Debug.LogWarning("pos1 nicht gefunden!");
                }
                
                if (pos2)
                {
                    Debug.Log("pos2 gefunden: " + pos2.position);
                    Instantiate(chairPrefab, pos2.position, pos2.rotation, table.transform);
                }
                else
                {
                    Debug.LogWarning("pos2 nicht gefunden!");
                }


            }
        }

        // Update is called once per frame
        
    }
}
