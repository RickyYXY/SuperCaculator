using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationsSolvingModule
{
    public class NonlinearEquations: CollectionBase
    {
        public NonlinearEquations() // 默认构造函数
        {
        }

        public NonlinearEquations(NonlinearEquations Equations) // 构造函数
        {
            AddEquations(Equations);
        }

        public NonlinearEquations(NonlinearEquation[] Equations) // 构造函数
        {
            AddEquations(Equations);
        }

        public NonlinearEquation this[int index]  // 索引符
        {
            get { return (NonlinearEquation)List[index]; }
            set { List[index] = value; }
        }

        public void AddEquation(NonlinearEquation newEquation) // 添加一个非线性方程
        {
            List.Add(newEquation);
        }

        public void Remove(NonlinearEquation oldEquation) // 移除一个非线性方程
        {
            List.Remove(oldEquation);
        }

        public int IndexOf(NonlinearEquation currentEquation) // 确定方程在方程组中的索引
        {
            return List.IndexOf(currentEquation);
        }

        public bool Contains(NonlinearEquation currentEquation) // 查看该方程是否在方程组中
        {
            return List.Contains(currentEquation);
        }

        public void Insert(int index, NonlinearEquation currentEquation) // 插入一个新的非线性方程
        {
            List.Insert(index, currentEquation);
        }

        public void AddEquations(NonlinearEquation[] Equations) // 添加非线性方程数组到当前集合
        {
            for (int i = 0; i < Equations.Length; i++)
            {
                this.AddEquation(Equations[i]);
            }
        }

        public void AddEquations(NonlinearEquations Equations) // 添加非线性方程集合到当前集合
        {
            for (int i = 0; i < Equations.Capacity; i++)
            {
                AddEquation((NonlinearEquation)Equations.List[i]);
            }
        }
    }
}
