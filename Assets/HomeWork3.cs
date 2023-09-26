using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HomeWork3 : MonoBehaviour
{
    //15��

    /*
    private void Awake()
    {
        ArrayList array = new ArrayList();
        array.Add(10);

        Debug.Log(array[0]);
    }
    */

    /*
    private void Awake()
    {
        ArrayList arrayList = new ArrayList();

        Debug.Log(arrayList.Add(10));

        PrintArrayList(arrayList);

        arrayList.Insert(1, 100);

        PrintArrayList(arrayList);

        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(3);
        data.Add(2);
        arrayList.Add(data);

        PrintArrayList(arrayList);

        arrayList.Sort();

        PrintArrayList(arrayList);

        arrayList.Remove(10);

        PrintArrayList(arrayList);

        arrayList.RemoveAt(0);

        PrintArrayList(arrayList);

        arrayList.RemoveRange(0, 2);

        PrintArrayList(arrayList);

        arrayList.Clear();

        Debug.Log(arrayList.Count);
    }

    public void PrintArrayList(ArrayList list)
    {
        Debug.Log("=================================");

        for(int i = 0; i < list.Count; i++)
        {
            Debug.Log($"list[{i}] = {list[i]}");
        }
    }
    */

    /*
    private void Awake()
    {
        Queue queue = new Queue();

        for(int i=0;i<5;++i)
        {
            queue.Enqueue(i);
        }

        Debug.Log($"Queue Count : {queue.Count}");

        Debug.Log($"���� 0�� ��� : {queue.Peek()}");

        Debug.Log($"Queue Count : {queue.Count}");

        object data = queue.Dequeue();
        Debug.Log($"ť���� �������� ������ : {data}");

        Debug.Log($"Queue Count : {queue.Count}");

        queue.Clear();

        Debug.Log($"Queue Count ; {queue.Count}");
    }
    */

    /*
    private void Awake()
    {
        Stack stack =new Stack();

        for (int i = 0;i<5; ++i)
        {
            stack.Push(i);
        }

        Debug.Log($"Stack Count : {stack.Count}");

        Debug.Log($"�������� �߰��� ��� : {stack.Peek()}");

        object data = stack.Pop();
        Debug.Log($"���ÿ� �������� ������ : {data}");

        Debug.Log($"Stack Count : {stack.Count}");

        stack.Clear();

        Debug.Log($"Stack Count : {stack.Count}");
    }
    */

    private void Awake()
    {
        Hashtable hash = new Hashtable();

        Goblin goblin = new Goblin();
        Slime slime = new Slime();

        hash["Goblin"] = goblin;

        hash.Add("Slime", slime);
        hash.Add(1, "����");
        hash.Add(1.2f, "�Ǽ�");
        hash.Add("�ȳ��ϼ���. ��ڻ��Դϴ�.", "���ڿ�");

        foreach (object key in hash.Keys)
        {
            Debug.Log($"hash[{key}] = {hash[key]}");
        }

        if (hash.ContainsKey("Slime"))
        {
            Debug.Log($"Slime Ű ����");
        }

        if(hash.ContainsValue(goblin))
        {
            Debug.Log($"{goblin} �� ����");
        }

        Debug.Log($"Hashtable Count : {hash.Count}");

        hash.Remove("Slime");

        Debug.Log($"Hashtable Count : {hash.Count}");

        hash.Clear();

        Debug.Log($"Hashtable Count : {hash.Count}");
    }

    public class Goblin { }

    public class Slime { }
}
