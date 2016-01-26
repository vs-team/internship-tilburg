﻿using UnityEngine;
using System.Collections;

public class UnityBazookaBullet : MonoBehaviour
{
  public Rigidbody Rbody;
  private Vector3 direct;


  public static UnityBazookaBullet Instantiate(Vector3 pos, string nm, float explosionradius, float damage)
  {
    GameObject Weapon = GameObject.Instantiate(Resources.Load("Weapons/" + nm), pos, Quaternion.Euler(new Vector3(-90, 0, 0))) as GameObject;
    UnityBazookaBullet wap = Weapon.GetComponent<UnityBazookaBullet>() as UnityBazookaBullet;
    wap.Rbody = Weapon.GetComponent<Rigidbody>() as Rigidbody;
    wap.explosionRadius = explosionradius;
    wap.gunPower = damage;
    Physics.IgnoreLayerCollision(wap.gameObject.layer, FindObjectOfType<TruckScript>().gameObject.layer); //Let the bazookabullet ignore the truck
    return wap;
  }
  public Vector3 Frce
  {
    set
    {
      Rbody.AddForce(value * 150.0f);
    }
  }
  void OnCollisionEnter(Collision coll)
  {
    Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius, 1 << 8/*zombie layermask*/);
    foreach (Collider c in colliders)
    {
      Vector3 ImpactDirection = (c.transform.position - transform.position).normalized;
      float ImpactForce = Mathf.InverseLerp(explosionRadius, 0.0f, Vector3.Distance(c.transform.position, transform.position)) * gunPower / 30.0f;
      Debug.Log(ImpactForce);

      if (coll.transform.tag == "Barrels")
      {
        c.GetComponent<Rigidbody>().AddForce(ImpactDirection * gunPower);
      }
      else
      {
        c.GetComponentInParent<UnityZombie2>().GetHit(ImpactDirection, c.transform, c.GetComponent<Rigidbody>(), c, ImpactForce, true, 1);
      }
    }

    if (coll.gameObject.name != "zpickup(Clone)")
    {
      GameObject expl = Instantiate(Resources.Load("Explosion03b"), transform.position, Quaternion.identity) as GameObject;
      Destroy(expl, 2.0f);
      destroyed = true; //Field instead of setter to allow deconstruction in CNV
    }
  }
  private float explosionRadius;
  public float ExplosionRadius
  {
    get { return explosionRadius; }
    set { explosionRadius = value; }
  }
  private float gunPower;
  public float GunDamage
  {
    get { return gunPower; }
    set { gunPower = value; }
  }
  private bool destroyed;
  public bool Destroyed
  {
    get { return destroyed; }
    set
    {
      destroyed = value;
      if (destroyed)
        GameObject.Destroy(gameObject);
    }
  }
}                                                                                                                                                                                                                                                                                                    