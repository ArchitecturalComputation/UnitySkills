using System.Collections.Generic;
using UnityEngine;


namespace MyProject
{
    public class LearningCode : MonoBehaviour
    {
        public GUISkin uiSkin;
        public string text = "";

        void Start()
        {
            // "value types": int,float, Rect, Vector3, Vector2,
            // "reference types":  int[], List<int>, uiSkin, gameobject

          //  var list = new List<int>();

           // int result = 0;

            //var math = new Mathf();
            //math.Sin(10);

            Mathf.Sin(10);
           // var cos = Mathf.Cos(2);

          //  var eyes = Animal.GetEyes();
            var dog = new Animal(10, 2, "woof");
            dog.Move(Vector3.up);
            Animal.GetEyes();

           // var cow = new Animal(4, 3, "moo");

            var animals = new List<Animal>();
            animals.Add(new Cat());
            animals.Add(new Dog());
            // animals.Add(new Vehicle());


            //var dog = new Dog();
            //dog.Fetch();

            foreach (var animal in animals)
            {
                //animal.Move(new Vector3(2, 5, 3));
                //animal.ChopLeg();
                text += $"Animal has {animal.Legs} legs left. ";
            }

            // myAnimal.Sound = null;
            // var sound = myAnimal.Sound;



            // text = string.Join(", ", numbers);
        }

        private void OnGUI()
        {
            GUI.skin = uiSkin;
            GUI.Label(new Rect(20, 20, 200, 50), text);
        }


        void ModifyList(List<int> n)
        {
            n = new List<int>();
            //  n[0] = 6;
        }
    }

    class Animal : IMovable
    {
        static int _eyes;

        protected int _legs;

        Vector3 _position;

        private string _sound;

        public int Legs => _legs;

        public static int GetEyes()
        {
            return _eyes;
        }

        public string Sound
        {
            get
            {
                return _sound;
            }

            set
            {
                if (value == null)
                    _sound = "invalid sound";
                else
                    _sound = value;
            }
        }

        public Animal(int legs, int eyes, string sound)
        {
            _legs = legs;
            _eyes = eyes;
            _sound = sound;

        }

        public virtual void ChopLeg()
        {
            if (_legs == 0) return;
            _legs -= 1;
        }

        public void Move(Vector3 delta)
        {
            _position += delta;
        }

        //public string MakeSound()
        //{
        //    return _sound;
        //}
    }

    class Dog : Animal
    {
        public Dog() : base(4, 2, "Woof")
        {

        }

        public override void ChopLeg()
        {
            if (_legs >= 2)
                _legs -= 2;
        }

        public void Fetch()
        {

        }
    }

    class Cat : Animal
    {
        public Cat() : base(4, 2, "Miao")
        {

        }
    }


    class Vehicle : IMovable
    {
        int _wheels;
        Vector3 _position;

        public void Move(Vector3 delta)
        {
            _position += delta;
        }
    }

    enum WeekDay { Mon, Tue, Wed, Thu, Fri }

    interface IMovable
    {
        void Move(Vector3 delta);
    }


}