using UnityEngine;
using UnityEngine.UI;

public class Raycaster : MonoBehaviour
{
    private static readonly float lookDelay = 3;
    private float counter = lookDelay;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit, 6))
        {
            if (hit.transform.gameObject.CompareTag("Display"))
            {
                GameObject parent = hit.transform.parent.gameObject;
                if (parent)
                {
                    counter -= Time.deltaTime;
                    if (counter <= 0)
                    {
                        parent.transform.Find("Holder").Find("Paint").gameObject.SendMessage("Info1");
                        counter = lookDelay;
                    }
                }
            }
            else
            {
                counter = lookDelay;
            }
        }

    }
}
