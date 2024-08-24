using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit6.Models.CAR
{
    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine = default;//Поле типа Т, со значением по умолчанию
        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
    }
}
