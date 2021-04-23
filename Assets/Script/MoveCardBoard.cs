using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCardBoard : MonoBehaviour
{
    public List<PositionTeleport> PositionsTeleport;

    public int PosActual;

    public void Teleport()
    {
        if (PosActual < PositionsTeleport.Count -1)
        {

            transform.position = PositionsTeleport[PosActual].transform.position;
            PositionsTeleport[PosActual].gameObject.SetActive(false);
            PosActual++;
        }
        else
        {
            PositionsTeleport[PosActual].gameObject.SetActive(false);
            PosActual = 0;
            transform.position = PositionsTeleport[PosActual].transform.position;
            PosActual++;
        }
       /* if (PosActual > 0 && PosActual <= PositionsTeleport.Count)
        {
            PositionsTeleport[PosActual - 1].gameObject.SetActive(true);
        }
        else if (PosActual == 0)
        {
            PositionsTeleport[PositionsTeleport.Count].gameObject.SetActive(true);
        }*/
        PositionsTeleport[PosActual].gameObject.SetActive(true);
    }
}
