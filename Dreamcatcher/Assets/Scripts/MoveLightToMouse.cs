using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLightToMouse : MonoBehaviour
{
    /// <summary>
    /// this update is just going to set the position of the player light to
    /// the mouse position
    /// </summary>
    public GameObject PlayerLight;
    Vector2 screenPosition;
    Vector2 worldPosition;
    void FixedUpdate()
    {
        screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        PlayerLight.transform.position = worldPosition;
    }
}
