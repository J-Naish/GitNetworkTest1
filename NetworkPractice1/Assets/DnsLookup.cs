using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;


public class DnsLookup : MonoBehaviour
{

    public string googleUrl = "www.google.com";

    public string amazonUrl = "amazon.com";


    private void Start()
    {
        System.Net.IPAddress[] googleAddresses = Dns.GetHostAddresses(googleUrl);

        System.Net.IPAddress[] amazonAddresses = Dns.GetHostAddresses(amazonUrl);
        

        Debug.Log("Google");
        foreach (var address in googleAddresses)
        {
            print(address);
        }


        Debug.Log("Amazon");
        foreach (var address in amazonAddresses)
        {
            print(address);
        }
    }

    
}
