using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework1 : MonoBehaviour
{
    //1��
    /*
    private int value01;

    private int value02, value03, value04;

    private int value05 = 10;

    private int value06 = 10, value07 = 20, value08 = 30;

    private void Awake() 
    {
        value01 = 1;
        value02 = 2;
        value03 = 3;
        value04 = 4;
    }
    */
    /*
    private int currentHP = 10;
    private readonly int maxHP = 100;
    private const int maxMP = 100;

    public Homework1()
    {
        maxHP = 200;
    }

    private void Awake()
    {
        int currentMP = 50;

        currentHP = 35;
        //maxHP = 200;
        //maxMP = 200;

        Debug.Log(currentHP);
        Debug.Log(currentMP);
        Debug.LogError(maxHP);
    }
    */
    /*
    public string playerName = "Noname";
    private int currentHP = 100;

    public void TakeDamage(int damage)
    {
        //damage��ŭ ü���� ����
        currentHP -= damage;

        Debug.Log(currentHP);
    }
    */
    /*
    private void Awake()
    {
        Player player;
        player = GameObject.Find("PlayerObject").Getcomponent<Player>();

        player.playerName = "��ڻ�";

        player.TakeDamage(10);
    }
    */

    //2��
    /*
    private void Awake()
    {
        sbyte byteValue = -128;
        byte ubytevalue = 255;
        short shortValue = -32768;
        ushort ushortValue = 65535;
        int intValue = -2147483648;
        uint uintValue = 4294967295;
        long longValue = -922337203685477508;
        ulong ulongValue = 18446744073709551615;
        char charValue = 'K';

        Debug.Log("byte Data : " + byteValue);
        Debug.Log("ubyte Data : " + ubytevalue);
        Debug.Log("short Data : " + shortValue);
        Debug.Log("ushort Data : " + ushortValue);
        Debug.Log("int Data : " + intValue);
        Debug.Log("uint Data : " + uintValue);
        Debug.Log("long Data : " + longValue);
        Debug.Log("ulong Data : " + ulongValue);
        Debug.Log("char Data ; " + charValue);
    }
    */

    /*
    private void Awake()
    {
        float floatValue01 = 3.141592653589793238462643383279f;
        float floatValue02 = 31.141592653589793238462643383279f;
        double doubleValue = 3.141592653589793238462643383279;
        decimal decimalValue = 3.141592653589793238462643383279m;

        Debug.Log("float Data : " + floatValue01);
        Debug.Log("float Data : " + floatValue02);
        Debug.Log("double Data : " + doubleValue);
        Debug.Log("decimal Data : " + decimalValue);


        string stringValue = "�ȳ��ϼ���.���� ��ڻ��Դϴ�.";
        bool boolValue = true;

        Debug.Log("string Data : " + stringValue);
        Debug.Log("bool Data : " + boolValue);


        object valueInt = 31;
        object valueFloat = 3.14159265358979f;
        object valueString = "��ü���� ���α׷���";
        object valueBool = false;

        Debug.Log("���� : " + valueInt);
        Debug.Log("�Ǽ� : " + valueFloat);
        Debug.Log("���ڿ� : " + valueString);
        Debug.Log("�� : " + valueBool);
    }
    */

    //3��
    /*
    private void Awake()
    {
        sbyte sbyteValue = 10;
        int intValue = (int)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);

        intValue = 130;
        sbyteValue = (sbyte)intValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intvalue : " + intValue);
    }
    */

    /*
    private void Awake()
    {
        sbyte sbyteValue = 31;
        byte byteValue = (byte)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        sbyteValue = -31;
        byteValue = (byte)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        byteValue = 200;
        sbyteValue = (sbyte)byteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);
    }
    */

    /*
    private void Awake()
    {
        float floatValue = 69.6875f;
        double doubleValue = (double)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("doubleValue : " + doubleValue);

        floatValue = 0.1f;
        doubleValue=(double)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("doubleValue : " + doubleValue);
    }
    */

    /*
    private void Awake()
    {
        float floatValue = 0.9f;
        int intValue = (int)floatValue;

        Debug.Log("floatValue ; " + floatValue);
        Debug.Log("intValue : " + intValue);

        floatValue = 1.1f;
        intValue =(int)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("intValue : " + intValue);
    }
    */

    /*
    private void Awake()
    {
        int intValue = 10;
        float floatValue = 12.3456f;
        string stringValue="33";

        Debug.Log("intValue : " + intValue);
        Debug.Log("floatValue : " + floatValue);
        Debug.Log("stringValue : " + stringValue);

        intValue = int.Parse(stringValue);
        stringValue = "33.4567";
        floatValue=float.Parse(stringValue);

        Debug.Log("intValue : " + intValue);
        Debug.Log("floatValue : " + floatValue);
        Debug.Log("stringValue : " + stringValue);
    }
    */

    /*
    private void Awake()
    {
        string stringValue = "���ڰ� �ƴմϴ�.";
        int intValue = 10;

        bool isConversion = int.TryParse(stringValue, out intValue);
        if(isConversion == true)
        {
            Debug.Log("stringValue : " + stringValue);
            Debug.Log("intValue : " + intValue);
        }
        else
        {
            Debug.Log("stringValue ������ ����ִ� ������ ���ڰ� �ƴϾ ����ȯ�� �����߽��ϴ�");
        }
    }
    */
    /*
    private void Awake()
    {
        const int PlayerIdle = 0;
        const int PlayerMove = 1;
        const int PlayerAttack = 2;

        int playerState = PlayerAttack;

        switch(playerState)
        {
            case PlayerIdle:
                Debug.Log("�÷��̾� ���� : ���");
                break;
            case PlayerMove:
                Debug.Log("�÷��̾� ���� : �̵�");
                break;
            case PlayerAttack:
                Debug.Log("�÷��̾� ���� : ����");
                break;
        }
    }
    */
    /*
    enum PlayerState {Idle, Move,Attack}
    private void Awake()
    {
        PlayerState playerState = PlayerState.Idle;

        switch (playerState)
        {
            case PlayerState.Idle:
                Debug.Log("�÷��̾� ���� : ���");
                break;
            case PlayerState.Move:
                Debug.Log("�÷��̾� ���� : �̵�");
                break;
            case PlayerState.Attack:
                Debug.Log("�÷��̾� ���� : ����");
                break;
        }
    }
    */
    /*
    private void Awake()
    {
        int? intValue;

        intValue = null;
        Debug.Log(intValue.HasValue);

        intValue = 30;
        Debug.Log(intValue.HasValue);
        //Debug.Log(intValue.Value);

        intValue = 30;
        Debug.Log(intValue.HasValue);
        Debug.Log(intValue.Value);

        var valueInt = 33;
        var valueFloat = 33.4567f;
        var valueString = "���ڿ�";

        Debug.Log("���� : " + valueInt);
        Debug.Log("�Ǽ� : " + valueFloat);
        Debug.Log("���ڿ� : " + valueString);
    }
    */

    /*
    private void Awake()
    {
        int minutes = 1;
        int seconds = 15;

        Debug.Log(string.Format("�⺻ : {0}{1}{2}",minutes,":",seconds));
        Debug.Log(string.Format("���� ���� : {0,-5}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("������ ���� : {0,5}{1}{2}", minutes, ":", seconds));

        Debug.Log(string.Format("10���� ����ȭ : {0:D}", 123));
        Debug.Log(string.Format("10���� ����ȭ(5�ڸ�) : {0:D5}", 123));

        Debug.Log(string.Format("16���� ����ȭ : {0:X}", 0x00));
        Debug.Log(string.Format("16���� ����ȭ(10�ڸ�) : {0:X10}", 0x00));

        Debug.Log(string.Format("�����Ҽ��� ����ȭ : {0:F}", 1.23));
        Debug.Log(string.Format("�����Ҽ��� ����ȭ(�Ҽ��� 1�ڸ�) : {0:F1}", 1.23));

        Debug.Log(string.Format("�޸��� ���� : {0:N}", 1234567890));
        Debug.Log(string.Format("���� : {0:E}", 1234567890));

        DateTime dt = new DateTime(2020, 2, 22, 13, 40, 0);
        string str = dt.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)");
        Debug.Log(str);

        str = dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)");
        Debug.Log(str);
    }
    */

    /*
    private void Awake()
    {
        int minutes = 1;
        int seconds = 15;

        Debug.Log(string.Format("{0}{1}{2}",minutes, " : ", seconds));
        Debug.Log($"{minutes} : {seconds}");

        Debug.Log(string.Format("{0, -10:D5}", minutes));
        Debug.Log($"{minutes,-10:D5}");
    }
    */

    /*
    private void Awake()
    {
        string str = "Hello, World";
        Debug.Log(str);

        int numeric = str.IndexOf("o");
        Debug.Log($"o�� �տ��� ���� {numeric + 1}��°�� �ֽ��ϴ�.");

        numeric=str.LastIndexOf("o");
        Debug.Log($"o�� �ڿ��� ���� {numeric}��°�� �ֽ��ϴ�.");

        bool isTrue = str.StartsWith("Hello");
        Debug.Log($"{str} ������ Hello���� �����Ѵ�? {isTrue}");

        isTrue = str.StartsWith("World");
        Debug.Log($"{str} ������ World���� �����Ѵ�? {isTrue}");

        isTrue = str.EndsWith("Hello");
        Debug.Log($"{str} ������ Hello�� ������? {isTrue}");

        isTrue = str.EndsWith("World");
        Debug.Log($"{str} ������ World�� ������? {isTrue}");

        isTrue = str.Contains("Hell");
        Debug.Log($"{str} ������ Hell�� ���ԵǾ� �ִ�? {isTrue}");
    }
    */

    /*
    private void Awake()
    {
        string str = "HELLO, WORLD";
        Debug.Log(str);

        str=str.ToLower();
        Debug.Log($"ToLower()- {str}");

        str=str.ToUpper();
        Debug.Log($"ToUpper()- {str}");

        str = str.Insert(0, "Hi~ ");
        Debug.Log($"Insert() - {str}");

        str = str.Remove(0, 4);
        Debug.Log($"Remove() - {str}");

        Debug.Log("== Trim ==");
        str = "    " + str + "    ";
        Debug.Log(str + "���� üũ");

        str = str.Trim();
        Debug.Log(str + "���� üũ");

        Debug.Log($"Before Replace : {str}");
        str = str.Replace("HELLO", "BYE");
        Debug.Log($"After Replace : {str}");
    }
    */

    /*
    private void Awake()
    {
        string position = "3, 5, 6";
        string[] str=position.Split(',');
        Debug.Log($"{str[0]},{str[1]},{str[2]}");

        string str2 = "HELLO, WORLD";
        str2 = str2.Substring(7);
        Debug.Log (str2);
    }
    */

    //6��
    /*
    private void Awake()
    {
        int a = 5 + 6;
        int b = a - 3;
        int c = a * b;
        int d = c / 8;
        int e = d % 4;

        Debug.Log($"{a} = 5 + 6");
        Debug.Log($"{b} = {a} - 3");
        Debug.Log($"{c} = {a} * {b}");
        Debug.Log($"{d} = {c} / 8");
        Debug.Log($"{e} = {d} % 4");
    }
    */

    /*
    private void Awake()
    {
        int a = 10;
        Debug.Log($"a = 10 : {a}");

        a += 10;
        Debug.Log($"a += 10 : ����� {a}");

        Debug.Log($"a -= 9 : ����� {a -= 9}");
        Debug.Log($"a *= 8 : ����� {a *= 8}");
        Debug.Log($"a /= 7 : ����� {a /= 7}");
        Debug.Log($"a %= 6 : ����� {a %= 6}");
        Debug.Log($"a &= 5 : ����� {a &= 5}");
        Debug.Log($"a |= 4 : ����� {a |= 4}");
        Debug.Log($"a ^= 3 : ����� {a ^= 3}");
        Debug.Log($"a <<= 2 : ����� {a <<=2}");
        Debug.Log($"a >>= 1 : ����� {a >>= 1}");
    }
    */

    /*
    private void Awake()
    {
        int a = 10;
        Debug.Log(a);

        a++;
        Debug.Log(a);

        ++a;
        Debug.Log(a);

        Debug.Log(a++);
        Debug.Log(a);
        Debug.Log(++a);
        Debug.Log(a);
    }
    */

    /*
    private void Awake()
    {
        int x = 5, y = 2;

        Debug.Log($"{x} > {y} = {x > y}");
        Debug.Log($"{x} < {y} = {x < y}");
        Debug.Log($"{x} >= {y} = {x >= y}");
        Debug.Log($"{x} <= {y} = {x <= y}");
        Debug.Log($"{x} == {y} = {x == y}");
        Debug.Log($"{x} != {y} = {x != y}");
    }
    */

    /*
    private void Awake()
    {
        bool result = false;
        int x = 5, y = 2;

        result = x > 2 & y != 5;
        Debug.Log($"{x} > 2 && {y} != 5 = {result}");

        result = x < 4 || y == 3;
        Debug.Log($"{x} < 4 || {y} == 3 = {result}");

        Debug.Log(result);
        result = !result;
        Debug.Log(result);

        int hp = -10;
        hp = hp < 0 ? 0 : hp;
        Debug.Log("ü�� : " + hp);
    }
    */

    /*
    private void Awake()
    {
        int a = 3;

        Debug.Log($"{a} << 1 = {a << 1}");
        Debug.Log($"{a} << 2 = {a << 2}");
        Debug.Log($"{a} << 3 = {a << 3}");
        Debug.Log($"{a} << 4 = {a << 4}");

        a = 3;
        Debug.Log($"{a} >> 1 = {a >> 1}");
        Debug.Log($"{a} >> 2 = {a >> 2}");
        Debug.Log($"{a} >> 3 = {a >> 3}");
        Debug.Log($"{a} >> 4 = {a >> 4}");

        a = -255;
        Debug.Log($"{a} >> 1 = {a >> 1}");
        Debug.Log($"{a} >> 2 = {a >> 2}");
        Debug.Log($"{a} >> 3 = {a >> 3}");
        Debug.Log($"{a} >> 4 = {a >> 4}");

        Debug.Log(Convert.ToString(a >> 4, 2));

        Debug.Log($"10 & 6 = {10 & 6}");
        Debug.Log($"10 | 6 = {10 | 6}");
        Debug.Log($"10 ^ 6 = {10 ^ 6}");
        Debug.Log($"~10 = {~10}");
    }
    */

    //7��
    /*
    [SerializeField]
    private int x = 10;
    private void Awake()
    {
        if(x%2==0)
        {
            Debug.Log("x�� ¦����");
        }

        if(x>5&&x<10)
        {
            Debug.Log("x�� 5���� ũ�� 10���� �۴�");
        }

        if(x>5)
        {
            if(x<10)
            {
                Debug.Log("x�� 5���� ũ�� 10���� �۴�");
            }
        }
    }
    */
    /*
    [SerializeField]
    private int x = 10;
    private void Awake()
    {
        if(x%2==0)
        {
            Debug.Log("x�� ¦����");
        }
        else
        {
            Debug.Log("x�� Ȧ����");
        }

    }
    */
    /*
    [SerializeField]
    private int x = 10;
    private void Awake()
    {
        if (x>=90)
        {
            Debug.Log("���� : A+");
        }
        else if(x>=80)
        {
            Debug.Log("���� : B+");
        }
        else if (x >= 70)
        {
            Debug.Log("���� : C+");
        }
        else if (x >= 60)
        {
            Debug.Log("���� : D");
        }
        else
        {
            Debug.Log("���� : F");
        }
    }
    */

    /*
    [SerializeField]
    private int x = 10;
    private void Awake()
    {
        x /= 10;

        switch(x)
        {
            case 10:
                Debug.Log("���� : A+");
                break;
            case 9:
                Debug.Log("���� : A+");
                break;
            case 8:
                Debug.Log("���� : B+");
                break;
            case 7:
                Debug.Log("���� : C+");
                break;
            case 6:
                Debug.Log("���� : D");
                break;
            default:
                Debug.Log("���� : F");
                break;
        }
    }
    */

    //8��
    /*
    [SerializeField]
    private int x = 10;
    private void Awake()
    {
       for(int index=0;index<10; ++index)
        {
            Debug.Log(index);
        }
    }
    */

    /*
    [SerializeField]
    private int x = 10;
    private void Awake()
    {
        for (int x=1;x<10;++x)
        {
            for(int y=1;y<10;++y)
            {
                Debug.Log($"{x} x {y} = {x * y}");
            }
        }
    }
    */

    /*
    [SerializeField]
    private int x = 10;
    private void Awake()
    {
        int result = 0;
        int index = 1;

        while (index <= 100)
        {
            result += index;

            index++;
        }

        Debug.Log($"1���� 100������ ���� {result}");
    }
    */

    /*
    [SerializeField]
    private int x = 10;
    private void Awake()
    {
        int[] enemys= new int[5]    ;

        Debug.Log($"�迭�� Ÿ�� : {enemys.GetType()}");
        Debug.Log($"�迭�� �⺻ Ÿ�� : {enemys.GetType().BaseType}");

        Debug.Log("== ���� �� ==");
        for(int index=0; index<enemys.Length; ++index)
        {
            enemys[index] = UnityEngine.Random.Range(0, 100);

            Debug.Log(enemys[index]);
        }

        Array.Sort(enemys);

        Debug.Log("== ���� �� ==");
        for (int index = 0; index < enemys.Length; ++index)
        {
            Debug.Log(enemys[index]);
        }

        Debug.Log($"Dimensions : {enemys.Rank}");
    }
    */

    [SerializeField]
    private int x = 10;
    private void Awake()
    {
        int[][] array = new int[3][];

        array[0]=new int[3] { 1, 2, 3 };
        array[1] = new int[] { 10, 20, 30, 40 };
        array[2] = new int[] { 100, 200, 300, 400 };

        for(int i = 0; i < array.Length; i++)
        {
            for(int j = 0; j < array[i].Length; j++)
            {
                Debug.Log($"[{i}][{j}]={array[i][j]}");
            }
        }
    }
}
