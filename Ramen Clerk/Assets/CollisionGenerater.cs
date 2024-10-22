using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class TagPair
{
    public string tag1;
    public string tag2;
    public GameObject GenerateObject;
    
}

public class CollisionGenerater : MonoBehaviour
{
    public List<TagPair> tagPairs;

    public GameObject newFood(string s1, string s2){
        foreach(TagPair t in tagPairs){
            if(t.tag1 == s1 && t.tag2 == s2){
                return t.GenerateObject;
            }
        }
        return null;
    }


}
