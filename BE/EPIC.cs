using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class EPIC : Story
    {
		private List<Story> relatedStories;

		public List<Story> RelatedStories
		{
			get { return relatedStories; }
			set { relatedStories = value; }
		}

	}
}