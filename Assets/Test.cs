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
        Debug.Log(power + "ダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        hp -= damage;
    }

    public void Magic(int magic)
    {
        if(mp >= 5)
        { 
            mp -= magic;
            Debug.Log("魔法攻撃をした。　残りMPは" + mp);
            

        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない");
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

        //配列の課題
        int[] array = { 1, 2, 3, 4, 5 };

        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for(int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
