using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace MyProject
{
    public class LearningCode : MonoBehaviour
    {
        public GUISkin uiSkin;
        public string text = "";

        void Start()
        {

            var numbers = new List<float>() { 1, 23, 55, 7, 3, 2 };


            var firstthree = FirstThree(numbers);
            var subset = numbers.Where(n => n > 3);

            var squares = numbers;

            var powers = PowersOfTwo();

            var sublist = powers
                .Take(5)
                .ToList();

            var dog = GetAnimal<Dog>();
        }

        IEnumerable<float> PowersOfTwo()
        {
            int i = 0;
            while (true)
            {
                float power = Mathf.Pow(2, i);
                Debug.Log(power);
                i++;
                yield return power;
            }
        }

        private void OnGUI()
        {
            GUI.skin = uiSkin;
            GUI.Label(new Rect(20, 20, 200, 50), text);
        }

        List<T> FirstThree<T>(List<T> input)
        {
            var sublist = new List<T>();
            sublist.Add(input[0]);
            sublist.Add(input[1]);
            sublist.Add(input[2]);

            return sublist;
        }


        List<int> GreaterThanThree(List<int> numbers)
        {
            var result = new List<int>();

            foreach (var num in numbers)
            {
                if (num > 3)
                    result.Add(num);
            }

            return result;
        }

        List<Animal> _animals;

        T GetAnimal<T>()
        {
            return _animals.OfType<T>().First();
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