using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int hp = 100;
    int power = 25;
    int mp = 53;

    public void Attack()
    {
        Debug.Log(power + "�_���[�W��^����");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        hp -= damage;
    }

    public void Magic(int magic)
    {
        if(mp >= 5)
        { 
            mp -= magic;
            Debug.Log("���@�U���������B�@�c��MP��" + mp);
            

        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ�");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);
        lastboss.Magic(5);

        for(int i = 1; i <= 10; i++)
        {
            lastboss.Magic(i);
        }

        //�z��̉ۑ�
        int[] array = { 1, 2, 3, 4, 5 };

        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for(int i = array.Length - 1; 0<= 1; i--)
        {
            Debug.Log(array[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
