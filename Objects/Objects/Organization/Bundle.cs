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
		/// Collection key is the streamId associated with the list of objects to use 
		/// </summary>
		[DetachProperty] public Dictionary<string, List<string>> referenceObjects { get; set; }

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
		public Bundle(string name, Dictionary<string, List<string>> referenceObjects)
		{
			this.name = name;
			this.referenceObjects = referenceObjects;
		}

		/// <summary>
		/// Checks if <see cref="name"/> and <see cref="referenceObjects"/> are similar
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool Equals(Bundle obj)
		{
			// check if name are similar along with collection of objects
			if (!this.name.Equals(obj.name) || obj.referenceObjects?.Count != this.referenceObjects?.Count)
				return false;

			foreach (var key in this.referenceObjects.Keys)
			{
				var ids = this.referenceObjects[key];

				// check that ids exists and are similar in size 
				if (!obj.referenceObjects.TryGetValue(key, out var objIds) || ids.Count != objIds.Count)
					return false;

				// check all ids
				for (int i = 0; i < ids.Count; i++)
				{
					if (!ids[i].Equals(objIds[i]))
						return false;
				}
			}

			return true;
		}
	}
}