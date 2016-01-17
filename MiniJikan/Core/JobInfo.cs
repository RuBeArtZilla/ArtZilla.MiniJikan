using System;
using System.Collections.Generic;

namespace ArtZilla.MiniJikan.Core {
	[Serializable]
	public class JobInfo {
		public CompanyInfo Company { get; set; } = new CompanyInfo();

		public List<LunchInfo> Lunches { get; set; } = new List<LunchInfo>();

		public List<WorkInfo> Workings { get; set; } = new List<WorkInfo>();
	}
}