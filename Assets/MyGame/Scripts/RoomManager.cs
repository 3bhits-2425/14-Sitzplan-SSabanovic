using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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

                // Sessel platzieren
                Transform[] chairPosition = table.GetComponentsInChildren<Transform>();
                foreach (Transform chairPos in chairPosition)
                {
                    if (chairPos.CompareTag("chair"))
                    {
                        GameObject chair = Instantiate(chairPrefab, chairPos.position, chairPos.rotation, table.transform);
                        Debug.Log("Found Chair");
                    }
                }


            }
        }

        // Update is called once per frame
        
    }
}
