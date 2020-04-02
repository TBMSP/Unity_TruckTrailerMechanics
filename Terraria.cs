using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Terraria:MonoBehaviour{
private Transform[] childs;
void Start(){
childs=new Transform[transform.childCount];
for(int i=0;i<childs.Length;i++){
childs[i]=transform.GetChild(i);
}
}
void Update(){
for(int i=1;i<childs.Length;i++){
var a=childs[i-1];
var b=childs[i];
var c=0.75f;
b.position=(b.position-a.position).normalized*(c+3)+a.position;
b.LookAt(a.position);
}
}
}