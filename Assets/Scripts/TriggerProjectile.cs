using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player hit");
            projectile.SetActive(true);
        }
    }
}
