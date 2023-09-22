using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 PackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    bool hasPackage=false;
    [SerializeField]float DestroyTime=0.5f;
    SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("çekill!!");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ezildin");
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Paket alýndý mý?");
            hasPackage = true;
            Destroy(other.gameObject,DestroyTime);
            spriteRenderer.color = PackageColor;
        }
        if(other.tag=="Customer" && hasPackage)
        {
            Debug.Log("Teslim edildi");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
       
    }
}
