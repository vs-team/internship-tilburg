﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

public class UnityPickUp : MonoBehaviour {

  public List<string> Shuffler(List<string> alpha)
  {
    for (int i = 0; i < alpha.Count; i++)
    {
      string temp = alpha[i];
      int randomIndex = Random.Range(i, alpha.Count);
      alpha[i] = alpha[randomIndex];
      alpha[randomIndex] = temp;
    }
    return alpha;
  }
  private List<string> a = new List<string>();

  public List<string> Shuffled
  {
    get
    {
      List<string> b = Shuffler(a);
      return b;
    }
    set { a = value; }
  }

}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  