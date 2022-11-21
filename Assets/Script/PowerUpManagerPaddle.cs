using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManagerPaddle : MonoBehaviour
{
   public Transform spawnArea;
    public int maxPowerUpAmount;
    public int spawanInterval;
    public Vector2 powerUpAreaMin;
    public Vector2 powerUpAreaMax;

    public List<GameObject> powerUpTemplateList; 

    private List<GameObject> powerUpList;

    private float timer;

    private void Start()
    {
        powerUpList = new List<GameObject>();
        timer = 0;
    }

    private void Update ()
    {
        timer += Time.deltaTime;
        if (timer > spawanInterval)
        {
            GenerateRandomPowerUp();
            timer -= spawanInterval;
        }
        Debug.Log ("Waktu: " + timer);

        //TEST YANG BERHASIL
        if (powerUpList.Count>=2 && timer > (spawanInterval-1))
        {
            Debug.Log ("Waktu Tunggu Spawn Hilang: " + timer);
            RemoveAllPowerUp();
        }
        
    }

    public void GenerateRandomPowerUp()
    {
        GenerateRandomPowerUp(new Vector2(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x),Random.Range(powerUpAreaMin.y,powerUpAreaMax.y)));
    }

    public void GenerateRandomPowerUp(Vector2 position)
    {
        
        if(powerUpList.Count >= maxPowerUpAmount)
        {
            return;
        }

        if (position.x < powerUpAreaMin.x ||
            position.x > powerUpAreaMax.x ||
            position.y < powerUpAreaMin.y ||
            position.y > powerUpAreaMax.y)
            {
                return;
            }

            Debug.Log("Test Spawn PowerUp Memanjangkan Pedal");

            int randomIndex = Random.Range(0, powerUpTemplateList.Count);

            GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex],new Vector3(position.x,position.y,powerUpTemplateList[randomIndex].transform.position.z),Quaternion.identity,spawnArea);
            powerUp.SetActive(true);

            powerUpList.Add(powerUp);
    }

    public void RemovePowerUp(GameObject powerUp)
    {
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUp()
    {
        while(powerUpList.Count>0)
        {
            RemovePowerUp(powerUpList[0]);
        }

    }

}
