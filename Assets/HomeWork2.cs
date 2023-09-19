using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class HomeWork2 : MonoBehaviour
{
    //10강

    /*
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public void Multiple(int num1, int num2)
        {
            int result = num1 * num2;
            Debug.Log($"{num1} x {num2} = {result}");
        }
    }
    */

    /*
    private void Awake()
    {
        Multiple(3, 4);
        Multiple(5, 8);
        Multiple(4, 6);
    }

    public void Multiple(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"{num1} x {num2} = {result}");
    }
    */

    /*
    private void Awake()
    {
        int a = int.Max(10, 20);
        Debug.Log(Max(100,200));
        Max(5, 10);
    }

    public int Max(int num1, int num2)
    {
        if(num1>num2)
        {
            return num1;
        }
        return num2;
    }
    */

    /*
    private void Awake()
    {
        int a = 3, b = 4;
        Debug.Log($"Before a= {a}, b={b}");
        Swap(a,b);
        Debug.Log($"After a= {a}, b={b}");
    }

    public void Swap(int num1, int num2 )
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    */

    /*
    private void Awake()
    {
        int a = 5, b = 4, result1 = 0, result2 = 0;
        Divide(a, b, out result1, out result2);
        Debug.Log($"몫={result1}, 나머지={result2}");
    }

    public void Divide(int num1, int num2, out int result1, out int result2)
    {
        result1=num1/num2;
        result2=num1%num2;
    }
    */

    /*
    public void Add(int num1, int num2)
    {
        int result = num1 + num2;
        Debug.Log($"{num1} + {num2} = {result}");
    }

    public void Add(float num1, float num2)
    {
        float result = num1 + num2;
        Debug.Log($"{num1} + {num2} = {result}");
    }
    */

    /*
    public void Sum(params int[] nums)
    {
        int sum = 0;
        for(int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];
        }
        Debug.Log($"합계 : {sum}");
    }
    */

    /*
    public void Player(string ID, int health=1000)
    {
        Debug.Log($"ID : {ID}, HP : {health}");
    }
    */

    //11강

    /*
    public class Player : MonoBehaviour
    {
        private string ID = "고박사";
        private int currentHP = 1000;

        public void TakeDamage(int damage)
        {
            if(currentHP > damage)
            {
                currentHP -= damage;
            }
        }
    }
    */

    /*
    public class Player
    {
        private string ID;
        private int currentHP;

        void RecoveryHP(int hp)
        {
            currentHP += hp;
        }

        public void TakeDamage(int damage)
        {
            if (currentHP > damage)
            {
                currentHP -= damage;
            }
        }
    }
    */

    /*
    public class Enemy
    {
        private PlayerPrefs player;

        public void AttackToTarget(PlayerPrefs target)
        {
            target.TakeDamage(100);
        }
    }
    */

    /*
    public class Player
    {
        public string ID;
        private int currentHP;

        public Player()
        {
            ID = "고박사";
            currentHP = 1000;
        }

        public Player(string id, int hp)
        {
            ID= id;
            currentHP = hp;
        }
    }

    public class GameController : MonoBehaviour
    {
        public Player player01;
        public Player player02; 

        private void Awake()
        {
            player01 = new Player();
            player02 = new Player("유니티",10);
        }
    }
    */

    /*
    public class Player
    {
        public string ID;
        private int health;

        ~Player()
        {
            //삭제되어유~
        }
    }
    */

    /*
    public class GameController : MonoBehaviour
    {
        private Player plyaer01;
        private Plyaer player02;

        private void Awake()
        {
            player01 = new Plyaer("고박사", 1000);
            player02 = player01;
            player02.ID = "유니티";
        }

        Debug.Log($"ID : {player01.ID}");
        Debug.Log($"ID : {player02.ID}");
    }
    */

    /*
    public class GameController : MonoBehaviour
    {
        private Player plyaer01;
        private Plyaer player02;

        private void Awake()
        {
            player01 = new Plyaer("고박사", 1000);
            player02 = player01.DeepCopy;
            player02.ID = "유니티";
        }

        Debug.Log($"ID : {player01.ID}");
        Debug.Log($"ID : {player02.ID}");
    }

    public class Player
    {
        public string ID;
        private int currentHP;

        public Player DeepCopy()
        {
            Player clone = new Player();
            clone.ID = ID;
            clone.currentHP = currentHP;

            return clone;
        }
    }
    */

    /*
    public class Player
    {
        public string ID;
        public Player()
        {
            ID = "고박사";
        }
    }
    
    public Player(int hp) :this()
    {
        currentHP = hp;
    }

    public Player(int hp, int mp) : this(hp)
    {
        currentMP = mp;
    }
    */

    //12강

    /*
    public class Player
    {
        private int currentHP;

        public void SetCurrentHP(int hp)
        {
            if(hp>0)
            {
                currentHP = hp; 
            }
        }

        public int GetCurrentHP()
        {
            return currentHP;
        }
    }

    public class GameController : MonoBehaviour
    {
        private void Awake()
        {
            Player player = new Player();

            player.currentHP = 100;
            Debug.Log($"HP : {player.currentHP}");

            player.SetCurrentHP(100);
            Debug.Log($"HP : {player.GetCurrentHP()}");
        }
    }
    */

    /*
    public class Entity
    {
        public string ID;
        protected int currentHP;

        private void Initialize()
        {
            ID = "Noname";
        }

        public void RecoveryHP(int hp)
        {
            currentHP += hp;
        }
    }

    public class Player : Entity
    {
        public Player(string id, int hp)
        {
            ID = id;
            currentHP = hp;

            RecoveryHP(1000);

            Initialize();
        }
    }
    */

    /*
    public class Entity
    {
        public string ID;
        protected int currentHP;
    }

    public class Player : Entity
    {
        private string ID;
        
        public Player(string id, int hp)
        {
            base.ID = "Noname";
            ID = id;
            currentHP = hp;
        }
    }
    */

    /*
    public class Entity
    {
        public void Attack()
        {
            Debug.Log("적을 공격한다.");
        }

        public void Heal()
        {
            Debug.Log("체력을 회복한다.");
        }
    }

    public class Goblin : Entity
    {
        public void Avoid()
        {
            Debug.Log("도망가자!!");
        }

        public void Heal()
        {
            Debug.Log("고블린의 체력 회복!");
        }
    }
    */

    /*
    public class Goblin
    {
        public void TakeDamagee(int damage)
        {
            Debug.Log($"고블린 : {damage}만큼 체력 감소");
        }
    }

    public class Slime
    {
        public void TakeDamagee(int damage)
        {
            Debug.Log($"슬라임 : {damage}만큼 체력 감소");
        }
    }
    public class Dragon
    {
        public void TakeDamagee(int damage)
        {
            Debug.Log($"드래곤 : {damage}만큼 체력 감소");
        }
    }

    public class Player
    {
        private int damage = 10;

        public void HIt(Goblin goblin)
        {
            goblin.TakeDamagee(damage);
        }

        public void HIt(Slime slime)
        {
            slime.TakeDamagee(damage);
        }
        public void HIt(Dragon dragon)
        {
            dragon.TakeDamagee(damage);
        }
    }
    private void Awake()
    {
        Player player = new Player();

        Goblin goblin = new Goblin();
        Slime slime = new Slime();
        Dragon dragon = new Dragon();

        player.HIt(goblin);
        player.HIt(slime);
        player.HIt(dragon);
    }
    */

    /*
    private void Awake()
    {
        Player player = new Player();

        Enemy goblin = new Gobline();
        Enemy slime = new Slime();
        Enemy dragon = new Dragon();

        player.Hit(goblin);
        player.Hit(slime);
        player.Hit(dragon);
    }
    */

    /*
    public class Entity
    {
        public virtual void Attack()
        {
            Debug.Log("적을 공격한다.");
        }
    }

    public class Slime : Entity
    {
        public override void Attack()
        {
            base.Attack();
            Debug.Log("슬라임의 몸통 박치기 공격!");
        }
    }

    public class Goblin : Entity
    {
        public override void Attack()
        {
            Debug.Log("고블린의 몽둥이 스매시");
        }
    }

    private Slime slime;
    private Goblin goblin;

    private void Awake()
    {
        slime=new Slime();
        goblin = new Goblin();
        slime.Attack();
        goblin.Attack();
    }
    */

    /*
    public class Entity
    {
        public void Attack()
        {
            Debug.Log("적을 공격한다.");
        }
    }

    public class Slime : Entity
    {
    }

    public class Goblin : Entity
    {
    }

    private void Awake()
    {
        Entity entity=new Slime();
        if(entity is Slime)
        {
            Debug.Log("Entity type is Slime");
        }

        Goblin goblin= entity as Goblin;
        if(goblin != null)
        {
            Debug.Log("goblin is null");
        }
    }
    */

    /*
    public abstract class Entity
    {
        protected int damage;
        protected int currentHP;

        public abstract void Attack(Entity target);
        public void TakeDamage(int damage)
        {
            if (currentHP > damage)
            {
                currentHP -= damage;
                Debug.Log($"체력이 {damage} 감소");
            }
            else
            {
                Debug.Log("Die");
            }
        }
    }

    public class Goblin : Entity
    {
        public Goblin(int damage, int hp)
        {
            base.damage = damage;
            currentHP = hp;
        }

        public override void Attack(Entity target)
        {
            Debug.Log("고블린의 몽둥이 스매시");
        }
    }

    public class Slime : Entity
    {
        public Slime(int damage, int hp)
        {
            base.damage = damage;
            currentHP = hp;
        }

        public override void Attack(Entity target)
        {
            Debug.Log("슬라임의 몸통 박치기");
            target.TakeDamage(damage);
        }
    }
    */

    /*
    interface IMovingEntity
    {
        void MoveTo(Vector3 destination);
    }

    public class Goblin : IMovingEntity
    {
        public void MoveTo(Vector3 destination)
        {
            Debug.Log($"{destination}까지 걸어서 이동");
        }
    }

    public class Slime : IMovingEntity
    {
        public void MoveTo(Vector3 destination)
        {
            Debug.Log($"{destination}까지 기어서 이동");
        }
    }

    public class Butterfly : IMovingEntity
    {
        public void MoveTo(Vector3 destination)
        {
            Debug.Log($"{destination}까지  날아서 이동");
        }
    }

    private IMovingEntity goblin;
    private IMovingEntity slime;
    private IMovingEntity butterfly;

    private void Awake()
    {
        goblin = new Goblin();
        slime=new Slime();
        butterfly = new Butterfly();

        goblin.MoveTo(new Vector3(1,2,3));
        slime.MoveTo(new Vector3(1,2,3));
        butterfly.MoveTo(new Vector3(1,2,3));
    }

    private IMovingEntity goblin;
    private IPerson player;

    private void Awake()
    {
        goblin= new Goblin();
        player = new PlayerPrefs();

        goblin.MoveTo(new Vector3(1, 2, 3));
        player.MoveTo(new Vector3(4,5,6));
        player.Talk("안녕하세요. 고박사입니다");
    }
    */

    //13강

    /*
    public class Parent
    {
        public void Method01()
        {
            Debug.Log("Parent");
        }
    }

    public class Child : Parent
    {
        public new void Method01()
        {
            Debug.Log("Child");
        }
    }

    private void Awake()
    {
        Parent p = new Parent();
        p.Method01();

        Child c= new Child();
        c.Method01();

        Parent pc= new Child();
        pc.Method01();
    }
    */

    /*
    public class Entity
    {
        public virtual void TakeDamage(int damage)
        {
            Debug.Log($"Entity : {damage}만큼 체력 감소");
        }
    }

    public class MovingEntity : Entity
    {
        public override void TakeDamage(int damage)
        {
            Debug.Log($"Entity : {damage}만큼 체력 감소");
        }
    }

    public class Player : MovingEntity
    {
        public override void TakeDamage(int damage)
        {
            Debug.Log($"Entity : {damage}만큼 체력 감소");
        }
    }
    */

    /*
    public partial class Player
    {
        public void CounterAttack() { }
    }

    public partial class Player
    {
        public void TakeDamage(int damage)
        {
            CounterAttack();
        }
    }
    */

    /*
    public struct Stats
    {
        public string ID;
        public int currentHP;
        public int damage;
    }

    private void Awake()
    {
        Stats player01 = new Stats();
        Stats player02;

        player02.ID = "고박사";
        player02.currentHP = 100;
        player02.damage = 99;

        Debug.Log($"{player01.ID}, 체력 : {player01.currentHP}, 공격력 : {player01.damage}");
        Debug.Log($"{player02.ID}, 체력 : {player02.currentHP}, 공격력 : {player02.damage}");
    }
    */

    /*
    var a = { "고박사", 35 };
    Debug.Log($"{a.Item1},{a.Item2}");

    a.Item2=36;
    Debug.Log($"{a.Item1},{a.Item2}");
    */

    /*
    public class Enemy
    {
        public int InstanceRun() { return 1; }

        public static int StaticRun()
        {
            InstanceRun();
            return 1;
        }
    }

    private void Awake()
    {
        int j= Enemy.StaticRun();

        Enemy enemey01=new Enemy();
        int i= enemey01.InstanceRun();
    }
    */

    /*
    public class Enemy
    {
        public int numeric;
        public static string specise;
    }

    private void Awake()
    {
        Enemy enemy01=new Enemy();
        enemy01.numeric = 0;
        Enemy enemy02=new Enemy();
        enemy02.numeric = 1;

        Debug.Log(enemy01.numeric);
        Debug.Log(enemy02.numeric);

        Enemy.specise = "고블린";
        Debug.Log(Enemy.specise);
    }
    */

    /*
    public static class Calculator
    {
        public static int num;
        static Calculator()
        {
            num = 1;
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }

    private void Awake()
    {
        Debug.Log(Calculator.Sum(20, 55));
        Debug.Log(Calculator.num);
    }
    */

    /*
    public static class StringExtension
    {
        public static void PrintData(this string str)
        {
            Debug.Log(str);
        }
    }

    private void Awake()
    {
        string str = "안녕하세요. 고박사입니다.";
        str.PrintData();
    }
    */

    //14강

    /*
    public class Player
    {
        private int currentHP;
        public int GetCurrentHP() { return currentHP; }
        public void SetCurrentHp(int hp) { currentHP = hp; }
    }

    private void Awake()
    {
        Player player=new Player();
        player.SetCurrentHp(100);
        Debug.Log($"Player HP : {player.GetCurrentHP()}");
    }
    */

    /*
    public class Player
    {
        private int currentHP;
        public int CurrentHP
        {
            get => currentHP;
            set
            {
                if(currentHP>0)
                {
                    currentHP = value;
                }
                else
                {
                    currentHP = 0;
                }
            }
        }
    }

    private void Awake()
    {
        Player player = new Player();
        player.CurrentHP = 100;
        Debug.Log($"Player HP : {player.CurrentHP}");
        player.CurrentHP = -100;
        Debug.Log($"Player {player.CurrentHP}");
    }
    */

    /*
    public class Player
    {
        public int CurrentHP
        {
            get;set;
        }

        public string ID
        {
            get; set;
        }
    }

    private void Awake()
    {
        Player player = new Player();
        player.ID = "고박사";
        player.CurrentHP = 100;
        Debug.Log($"{player.ID} HP : {player.CurrentHP}");
    }
    */

    /*
    public class Player
    {
        private int currentHP;
        public int CurrentHP
        {
            private set => currentHP= value;
            get => currentHP;
        }
    }
    */

    /*
    public class Player
    {
        public int CurrentHP
        {
            get;set;
        }
        public string ID
        {
            get; set;
        }
    }

    private void Awake()
    {
        Player player = new Player()
        {
            player.ID = "고박사",
            player.CurrentHP = 100
        };

        Debug.Log($"{player.ID} HP : {player.CurrentHP}");
    }
    */



    /*
    public abstract class BaseEntity
    {
        abstract public int Shield
        {
            get; set;
        }
        public int Defense
        {
            get; set;
        }
    }

    public class Player: BaseEntity
    {
        public override int Shield
        {
            get; set;
        }

        public int ID
        {
            get; set;
        }
    }

    private void Awake()
    {
        Player player = new Player();
        {
            player.ID = "고박사",
            player.Shield = 50,
            player.Defense = 10,
        };
        
        Debug.Log($"ID : {player.ID"};
        Debug.Log($"방어력 : {player.Defense}, 방어막 : {player.Shield}");
     }
    */

}