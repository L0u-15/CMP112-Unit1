using TMPro;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    private int Coin = 0;
    public TextMeshProUGUI CoinText;
    private void OnTriggerEnter(Collider coin)
    {
        if (coin.transform.tag == "coin")
        {
            Coin++;
            CoinText.text = "Coin:"  + Coin.ToString();
            Destroy(coin.gameObject);
        }
    }

}
