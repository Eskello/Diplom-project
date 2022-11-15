using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pickupable : MonoBehaviour
{
    [SerializeField] private int num;

    private int level;

    private void Start()
    {
        level = SceneManager.GetActiveScene().buildIndex;

        //gameobject.SetActive(!(ESave.Load(level, num)));
    }

    public void Pickup()
    {
        //ESave.Save(level, num, true);
    }
}
