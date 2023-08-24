using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using SimpleCalculator;

namespace ExtendedOperations
{
	[Export(typeof(IOperation))]
	[ExportMetadata("Symbol", '%')]
	public class Mod : IOperation
	{
		public int Operate(int left, int right)
		{
			return left % right;
		}
	}

}

