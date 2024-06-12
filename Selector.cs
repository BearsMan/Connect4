using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    Debug.Log(hit.collider.gameObject.name);
                    if (hit.collider.GetComponent<TokenDrops>() != null)
                    {
                        hit.collider.GetComponent<TokenDrops>().SpawnToken();
                    }
                }
            }
        }
    }
}
