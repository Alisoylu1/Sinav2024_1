using System;
using TMPro;
using UnityEditor.Callbacks;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
    // Ad Soyad: onur bardak
    // Öğrenci Numarası: 232011038


    // Soru 1: Karakteri yön tuşları ile hareket ettiren kodu, HareketEt fonksiyonu içerisine yazınız.
    // Soru 2: Karakterin zıplamasını sağlaması beklenen Zipla metodu doğru bir şekilde çalışmıyor, koddaki hatayı düzeltin.
    // Soru 3: Karakterin 'Engel' tag'ine sahip objeye temas ettiğinde metin objesine "Oyun Bitti!" yazısını yazdırınız.
    // Soru 4: Karakterin 'Puan' tag'ine sahip objeye temas ettiğinde skoru 1 arttırınız ve metin objesine yazdırınız.          

    // Not: Engel ve Puan nesnelerinin isTrigger özelliği aktiftir.


    public TMP_Text metin;
    private Rigidbody2D karakterRb;

    public float hiz = 5f;
    public float ziplamaGucu = 5f;

    public float KeyCount = 0 ;


    public int skor = 0;

    void Start()
    {
        karakterRb = GetComponent<Rigidbody2D>();
    }

    void HareketEt()
    {
      
    }
    void Update()
    {
        if(Input.getkey.(Keycode.a));
        Rb.AddForce(Vector2.left*(hiz*Time.deltaTime));
        if(Input getkey(KeyCode .Space));
        Rb.AddForce(Vector2.up*(zıplama*Time.deltaTime));
        // Yazdığınız metodları çağırınız.
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        skor+=1
        destroy(other.gameobject);
        skor text.TMP_Text="skor = " + skor;
        // Soru 3 ve soru 4 burada çözülecek.

    }

    void Zipla()
    {
        // Space tuşuna basınca karakter zıplamalı ancak aşağıdaki kod hatalı.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 ziplamaYonu = new Vector3(UnityEngine.Random.Range(-1f, 1f), 1, UnityEngine.Random.Range(-1f, 1f));
            karakterRb.AddForce(ziplamaYonu * (ziplamaGucu / 2), ForceMode.Impulse);


        }
    }
}