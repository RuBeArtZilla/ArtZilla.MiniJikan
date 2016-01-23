using System;
using System.Collections.Generic;
using ArtZilla.MiniJikan.Core.Data;

namespace ArtZilla.MiniJikan.Core {
	public class Day {
		public DateTime Date { get; }

		public TimeSpan Worked { get; set; }

		public TimeSpan Counted { get; set; }

		public List<WorkInfo> WorkList { get; set; }

		public bool IsWorkday { get; set; }

		public Day Transfer { get; set; }

		public LunchInfo Lunch { get; set; }
	}
}