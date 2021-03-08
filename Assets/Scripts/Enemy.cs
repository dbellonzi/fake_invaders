using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  [SerializeField] public GameManager gameManager;
  [SerializeField] public MotherScript motherScript;
  
  public int scoreValue;
  public GameObject bullet;
  public Transform shottingOffset;
  
    // Start is called before the first frame update
  void OnCollisionEnter2D(Collision2D collision)
  {
    gameManager.EnemyHit(this);
    motherScript.LostChild();
    Destroy(collision.collider.gameObject);
    Destroy(this.gameObject);
  }

  void Update()
  {
    int temp = Random.Range(0, 1000);
    if (temp == 42)
    {
      GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
      Debug.Log(temp);


      Destroy(shot, 4f);
    }
  } 
}
