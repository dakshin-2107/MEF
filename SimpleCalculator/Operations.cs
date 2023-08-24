using System.ComponentModel.Composition;

namespace SimpleCalculator
{
	[Export(typeof(IOperation))]
	[ExportMetadata("Symbol", '+')]
	class Add : IOperation
	{
		/*
			The ExportAttribute attribute functions as it did before. 
			The ExportMetadataAttribute attribute attaches metadata, in the form of a name-value pair, to that export. 
			While the Add class implements IOperation, a class that implements IOperationData is not explicitly defined. 
			Instead, a class is implicitly created by MEF with properties based on the names of the metadata provided. 
			(This is one of several ways to access metadata in MEF.)
		*/

		public int Operate(int left, int right)
		{
			return left + right;
		}
	}

	[Export(typeof(IOperation))]
	[ExportMetadata("Symbol", '-')]
	class Subtract : IOperation
	{
		public int Operate(int left, int right)
		{
			return left - right;
		}
	}
}
