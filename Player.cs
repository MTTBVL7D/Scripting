using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip damageSound;
    public int coins;
    private int health = 10;
    public int maxHealth = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;


    public void TakeDamage(int damage)
    {
        health -= damage;


        if (health > 0)
        {
            audioSource.PlayOneShot(damageSound);
            print("Здоровье игрока:" + health);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    public void CollectCoins()
    {
        coins++;
    }
}

