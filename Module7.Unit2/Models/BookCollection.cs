using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit2.Models
{
    //Класс для объекта "Коллекция книг"
    internal class BookCollection
    {
        //Закрытое поле, хранящее книги в виде массива
        private Book[] collection;

        //конструктор с добавлением массива книг
        public BookCollection(Book[] collection)
        {
            this.collection = collection;
        }

        //индексатор по массиву
        public Book this[int index] 
        {
            get 
            {
                if (index >= 0 && index < collection.Length)
                {
                    return collection[index];
                }
                else
                {
                    return null;
                }
            }
            private set 
            {
                if (index >= 0 && index < collection.Length)
                {
                    collection[index] = value;
                }
            }

        }
    }
}
