using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_面向对象基础
{
    /// <summary>
    /// 关于票价的实体模型
    /// </summary>
    class Ticket
    {
        //行驶里程与单价
        private double _distance;
        private double _price;

        //构造函数
        public Ticket(double distance)
        {
            if (distance < 0)
            {
                this.Distance = 0;
            }
            else
            {
                this.Distance = distance;
            }
        }

        //get和set方法
        public double Distance
        {
            set { _distance = value; }
            get { return _distance; }
        }

        public double Price
        {
            get
            {
                if (_distance <= 100)
                {
                    //返回值为double，更严谨一点
                    return _distance * 1.0;
                }
                else if (100 < _distance && _distance <= 200)
                {
                    return _distance * 0.95;
                }
                else if (200 < _distance && _distance <= 300)
                {
                    return _distance * 0.9;
                }
                else
                {
                    return _distance * 0.8;
                }
            }
            set { _price = value; }
        }

        public void ShowTicket()
        {
            Console.WriteLine("{0}公里需要票价为{1}", this.Distance, this.Price);
        }
    }
}
