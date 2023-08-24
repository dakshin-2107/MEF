using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace SimpleCalculator
{ 
	public class Program
	{
		private CompositionContainer _container;

		[Import(typeof(ICalculator))]
		public ICalculator calculator;

		public static void Main(string[] args)
		{
			// Composition is performed in the constructor.
			var p = new Program();
			Console.WriteLine("Enter Command:");
			while (true)
			{
				string s = Console.ReadLine();
				Console.WriteLine(p.calculator.Calculate(s));
			}
		}

		public Program()
		{
			try
			{
				// An aggregate catalog that combines multiple catalogs.
				var catalog = new AggregateCatalog();
				// Adds all the parts found in the same assembly as the Program class.
				// catalog.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));
				//  PS We have made the output of the Extension project, the Extension folder. 
				//  The DirectoryCatalog will now add any parts found
				//  in any assemblies in the Extensions directory to the composition container.
				catalog.Catalogs.Add(new DirectoryCatalog("./../../../Extensions/Debug/net7.0"));

				// Create the CompositionContainer with the parts in the catalog.
				_container = new CompositionContainer(catalog);
				_container.ComposeParts(this);
			}
			catch (CompositionException compositionException)
			{
				Console.WriteLine(compositionException.ToString());
			}
		}

	}
}

