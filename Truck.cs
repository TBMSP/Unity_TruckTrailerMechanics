using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Truck:MonoBehaviour{
public Transform pivotTruck,trailer;
public float trailerDistance;
void Update(){
trailer.position=(trailer.position-pivotTruck.position).normalized*trailerDistance+pivotTruck.position;
trailer.LookAt(pivotTruck.position);
}
}