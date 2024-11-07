using System;
using TMPro;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
    // Ad Soyad: Ali Soylu
    // Öğrenci Numarası: 232011013


    // Soru 1: Karakteri yön tuşları ile hareket ettiren kodu, HareketEt fonksiyonu içerisine yazınız.
    // Soru 2: Karakterin zıplamasını sağlaması beklenen Zipla metodu doğru bir şekilde çalışmıyor, koddaki hatayı düzeltin.
    // Soru 3: Karakterin 'Engel' tag'ine sahip objeye temas ettiğinde metin objesine "Oyun Bitti!" yazısını yazdırınız.
    // Soru 4: Karakterin 'Puan' tag'ine sahip objeye temas ettiğinde skoru 1 arttırınız ve metin objesine yazdırınız.

    // Not: Engel ve Puan nesnelerinin isTrigger özelliği aktiftir.


    public TMP_Text metin;
    private Rigidbody2D karakterRb;

    public float hiz = 5f;
    public float ziplamaGucu = 5f;


    public int skor = 0;
    private int keyCount=0;

    void Start()
    {
        karakterRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Yazdığınız metodları çağırınız.
        Zipla();
        HareketEt();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Puan")) 
            {
            skor++;
            Destroy(other.gameObject);
            metin.text = "Score: " + skor;
            }
           
        if (other.gameObject.CompareTag("Engel"))


            
            {
                Debug.Log("Oyun Bitti");
                

            }
    }

    void Zipla()
    {
        // Space tuşuna basınca karakter zıplamalı ancak aşağıdaki kod hatalı.
        if (Input.GetKey(KeyCode.Space))
        {
            //Vector3 ziplamaYonu = new Vector3(UnityEngine.Random.Range(-1f, 1f), 1, UnityEngine.Random.Range(-1f, 1f));
            //karakterRb.AddForce(ziplamaYonu * (ziplamaGucu / 2), ForceMode2D.Impulse);
            karakterRb.AddForce(UnityEngine.Vector3.up * (ziplamaGucu * Time.deltaTime));

        }
    }
    void HareketEt()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) 
    {
        karakterRb.AddForce(UnityEngine.Vector3.left * (hiz * Time.deltaTime)); 
    }
    else if (Input.GetKey(KeyCode.RightArrow)) 
    {
        karakterRb.AddForce(UnityEngine.Vector3.right * (hiz * Time.deltaTime));
    }
    }
}