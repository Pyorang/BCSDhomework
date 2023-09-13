using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework1 : MonoBehaviour
{
    //1장
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
        //damage만큼 체력을 감소
        currentHP -= damage;

        Debug.Log(currentHP);
    }
    */
    /*
    private void Awake()
    {
        Player player;
        player = GameObject.Find("PlayerObject").Getcomponent<Player>();

        player.playerName = "고박사";

        player.TakeDamage(10);
    }
    */

    //2장
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


        string stringValue = "안녕하세요.나는 고박사입니다.";
        bool boolValue = true;

        Debug.Log("string Data : " + stringValue);
        Debug.Log("bool Data : " + boolValue);


        object valueInt = 31;
        object valueFloat = 3.14159265358979f;
        object valueString = "객체지향 프로그래밍";
        object valueBool = false;

        Debug.Log("정수 : " + valueInt);
        Debug.Log("실수 : " + valueFloat);
        Debug.Log("문자열 : " + valueString);
        Debug.Log("논리 : " + valueBool);
    }
    */

    //3장
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
        string stringValue = "숫자가 아닙니다.";
        int intValue = 10;

        bool isConversion = int.TryParse(stringValue, out intValue);
        if(isConversion == true)
        {
            Debug.Log("stringValue : " + stringValue);
            Debug.Log("intValue : " + intValue);
        }
        else
        {
            Debug.Log("stringValue 변수에 들어있는 내용이 숫자가 아니어서 형변환에 실패했습니다");
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
                Debug.Log("플레이어 상태 : 대기");
                break;
            case PlayerMove:
                Debug.Log("플레이어 상태 : 이동");
                break;
            case PlayerAttack:
                Debug.Log("플레이어 상태 : 공격");
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
                Debug.Log("플레이어 상태 : 대기");
                break;
            case PlayerState.Move:
                Debug.Log("플레이어 상태 : 이동");
                break;
            case PlayerState.Attack:
                Debug.Log("플레이어 상태 : 공격");
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
        var valueString = "문자열";

        Debug.Log("정수 : " + valueInt);
        Debug.Log("실수 : " + valueFloat);
        Debug.Log("문자열 : " + valueString);
    }
    */

    /*
    private void Awake()
    {
        int minutes = 1;
        int seconds = 15;

        Debug.Log(string.Format("기본 : {0}{1}{2}",minutes,":",seconds));
        Debug.Log(string.Format("왼쪽 맞춤 : {0,-5}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("오른쪽 맞춤 : {0,5}{1}{2}", minutes, ":", seconds));

        Debug.Log(string.Format("10진수 서식화 : {0:D}", 123));
        Debug.Log(string.Format("10진수 서식화(5자리) : {0:D5}", 123));

        Debug.Log(string.Format("16진수 서식화 : {0:X}", 0x00));
        Debug.Log(string.Format("16진수 서식화(10자리) : {0:X10}", 0x00));

        Debug.Log(string.Format("고정소수점 서식화 : {0:F}", 1.23));
        Debug.Log(string.Format("고정소수점 서식화(소수점 1자리) : {0:F1}", 1.23));

        Debug.Log(string.Format("콤마로 구분 : {0:N}", 1234567890));
        Debug.Log(string.Format("지수 : {0:E}", 1234567890));

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
        Debug.Log($"o는 앞에서 부터 {numeric + 1}번째에 있습니다.");

        numeric=str.LastIndexOf("o");
        Debug.Log($"o는 뒤에서 부터 {numeric}번째에 있습니다.");

        bool isTrue = str.StartsWith("Hello");
        Debug.Log($"{str} 문장은 Hello부터 시작한다? {isTrue}");

        isTrue = str.StartsWith("World");
        Debug.Log($"{str} 문장은 World부터 시작한다? {isTrue}");

        isTrue = str.EndsWith("Hello");
        Debug.Log($"{str} 문장은 Hello로 끝난다? {isTrue}");

        isTrue = str.EndsWith("World");
        Debug.Log($"{str} 문장은 World로 끝난다? {isTrue}");

        isTrue = str.Contains("Hell");
        Debug.Log($"{str} 문장은 Hell이 포함되어 있다? {isTrue}");
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
        Debug.Log(str + "공백 체크");

        str = str.Trim();
        Debug.Log(str + "공백 체크");

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

    //6장
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
        Debug.Log($"a += 10 : 결과값 {a}");

        Debug.Log($"a -= 9 : 결과값 {a -= 9}");
        Debug.Log($"a *= 8 : 결과값 {a *= 8}");
        Debug.Log($"a /= 7 : 결과값 {a /= 7}");
        Debug.Log($"a %= 6 : 결과값 {a %= 6}");
        Debug.Log($"a &= 5 : 결과값 {a &= 5}");
        Debug.Log($"a |= 4 : 결과값 {a |= 4}");
        Debug.Log($"a ^= 3 : 결과값 {a ^= 3}");
        Debug.Log($"a <<= 2 : 결과값 {a <<=2}");
        Debug.Log($"a >>= 1 : 결과값 {a >>= 1}");
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
        Debug.Log("체력 : " + hp);
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

    //7강
    /*
    [SerializeField]
    private int x = 10;
    private void Awake()
    {
        if(x%2==0)
        {
            Debug.Log("x는 짝수다");
        }

        if(x>5&&x<10)
        {
            Debug.Log("x는 5보다 크고 10보다 작다");
        }

        if(x>5)
        {
            if(x<10)
            {
                Debug.Log("x는 5보다 크고 10보다 작다");
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
            Debug.Log("x는 짝수다");
        }
        else
        {
            Debug.Log("x는 홀수다");
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
            Debug.Log("학점 : A+");
        }
        else if(x>=80)
        {
            Debug.Log("학점 : B+");
        }
        else if (x >= 70)
        {
            Debug.Log("학점 : C+");
        }
        else if (x >= 60)
        {
            Debug.Log("학점 : D");
        }
        else
        {
            Debug.Log("학점 : F");
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
                Debug.Log("학점 : A+");
                break;
            case 9:
                Debug.Log("학점 : A+");
                break;
            case 8:
                Debug.Log("학점 : B+");
                break;
            case 7:
                Debug.Log("학점 : C+");
                break;
            case 6:
                Debug.Log("학점 : D");
                break;
            default:
                Debug.Log("학점 : F");
                break;
        }
    }
    */

    //8강
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

        Debug.Log($"1부터 100까지의 합은 {result}");
    }
    */

    /*
    [SerializeField]
    private int x = 10;
    private void Awake()
    {
        int[] enemys= new int[5]    ;

        Debug.Log($"배열의 타입 : {enemys.GetType()}");
        Debug.Log($"배열의 기본 타입 : {enemys.GetType().BaseType}");

        Debug.Log("== 정렬 전 ==");
        for(int index=0; index<enemys.Length; ++index)
        {
            enemys[index] = UnityEngine.Random.Range(0, 100);

            Debug.Log(enemys[index]);
        }

        Array.Sort(enemys);

        Debug.Log("== 정렬 후 ==");
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
