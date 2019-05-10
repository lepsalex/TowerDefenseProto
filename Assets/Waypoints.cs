using UnityEngine;
using System.Linq;

public class Waypoints : MonoBehaviour {
  public static Transform[] points;

  void Awake() {
    points = Enumerable.Range(0, transform.childCount)
                .Select(x => transform.GetChild(x))
                .ToArray();
  }
}
