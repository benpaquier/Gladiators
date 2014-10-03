using System;

namespace Application
{
	public class ExempleSingleton
	{

		private static ExempleSingleton _Instance;
		public static ExempleSingleton Instance {
			get {
				if (ExempleSingleton._Instance == null) {
					ExempleSingleton._Instance = new ExempleSingleton ();
				}
				return ExempleSingleton._Instance;
			}
				
		}



		private ExempleSingleton ()
		{	 
		}
	}
}

