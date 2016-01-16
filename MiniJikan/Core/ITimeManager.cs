using System;
using System.Xml;

namespace ArtZilla.MiniJikan.Core {
	public interface ITimeManager {
		TimeSpan GetTotalRequired(ushort year, ushort month);

		TimeSpan GetTotalWorked(ushort year, ushort month);

		TimeSpan GetTotalCounted(ushort year, ushort month);

		bool IsClosed(ushort year, ushort month);

		bool IsClosed(ushort year);

		TimeSpan GetTimeLeft(DateTime day);

		XmlDocument GetConfiguration();
	}
}