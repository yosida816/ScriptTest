using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boss
{
    private int hp = 100;          // �̗�
    private int power = 25; // �U����
    private int mp = 53;  // �U����



    public void magic()
    {
      

        if (mp>=5)
        {
            mp -= 5;
            Debug.Log("���@�U���������B�c��MP��"+mp+"�B");



        }
    else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");

        }
    }

        
        
    
    
        
       
                
                     


    // �U���p�̊֐�
    public void Attack()
    {
        if (mp>=5) {Debug.Log(this.power + "�̃_���[�W��^����");}}
           
            
        
    

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

}
public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[5];


        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        for (int i = 4; i >= 0; i--)
            Debug.Log(array[i]);
        for (int i = 0; i < 5; i++)
            Debug.Log(array[i]);


        Boss lastboss = new Boss();

        for (int i = 0; i < 10; i++)
            lastboss.magic();


        lastboss.magic();







    }


      

    // Update is called once per frame
    void Update()
    {
        
    }
}
