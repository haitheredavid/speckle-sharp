using System.Collections.Generic;
using Speckle.Core.Models;

namespace Objects.Organization
{
	/// <summary>
	/// A simple organization object that links multiple speckle objects into one bundle.
	/// All linked objects must be situated on the same server
	/// </summary>
	public class Bundle : Base
	{
		/// <summary>
		/// Name of the bundle
		/// </summary>
		public string name { get; set; }

		/// <summary>
		/// A list of reference object Ids to link together
		/// </summary>
		[DetachProperty] public List<string> referenceObjects { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public Bundle()
		{ }

		/// <summary>
		/// Basic constructor 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="referenceObjects"></param>
		public Bundle(string name, List<string> referenceObjects)
		{
			this.name = name;
			this.referenceObjects = referenceObjects;
		}

	}
}