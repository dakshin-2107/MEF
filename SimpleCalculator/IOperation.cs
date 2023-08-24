using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
	public interface IOperation
	{
		int Operate(int left, int right);
	}

	public interface IOperationData
	{
		char Symbol { get; }
	}
}
