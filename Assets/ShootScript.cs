using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    
    public Burger burger;
    
    static int i = 6;
    public void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if(hit.transform.tag == "Player")
            {
                Destroy(hit.transform.gameObject);
                i --;
                if(i == 0)
                {
                    burger.GetPanel();
                }
                //Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }
    }
}