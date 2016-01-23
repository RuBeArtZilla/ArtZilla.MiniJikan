using System.Collections.Generic;

namespace ArtZilla.MiniJikan.Core {
	public class YearInfo {
		public readonly Dictionary<ushort, MonthInfo> Months = new Dictionary<ushort, MonthInfo>();
		public bool IsClosed { get; }
	}
}