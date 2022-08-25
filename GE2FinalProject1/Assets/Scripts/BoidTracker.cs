using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class BoidTracker : MonoBehaviour
{
    public static BoidTracker instance;

    private void Awake()
    {
        instance = this;
    }

    public string[] tags = new[]
    {
        "StarWars",
        "BattleStar",
        "NextGen"
    };

    public int starWars = 0;
    public int battleStar = 0;
    public int nextGen = 0;
    public TMP_Text starWarsUICounter;
    public TMP_Text starTrekUICounter;
    public TMP_Text battleStarUICounter;

    public List<Boid> allBoids = new List<Boid>();

    private void Update()
    {
        allBoids = FindObjectsOfType<Boid>().ToList();

        starWars = 0;
        nextGen = 0;
        battleStar = 0;

        foreach (var boid in allBoids)
        {
            if (boid.gameObject.CompareTag(tags[0]))
            {
                starWars++;
            }
            else if (boid.gameObject.CompareTag(tags[1]))
            {
                battleStar++;
            }
            else if (boid.gameObject.CompareTag(tags[2]))
            {
                nextGen++;
            }

            starWarsUICounter.text = "Star Wars: " + BoidTracker.instance.starWars;

            starTrekUICounter.text = "Star Trek: " + BoidTracker.instance.nextGen;

            battleStarUICounter.text = "Battlestar: " + BoidTracker.instance.battleStar;
        }
    }

    

   
}
