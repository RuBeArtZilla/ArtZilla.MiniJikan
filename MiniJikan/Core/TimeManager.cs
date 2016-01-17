using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ArtZilla.MiniJikan.Core {
	public class TimeManager : ITimeManager {
		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Object"/> class.
		/// </summary>
		public TimeManager() { }

		#region Implementation of ITimeManager

		public TimeSpan GetTotalRequired(ushort year, ushort month) {
			throw new NotImplementedException();
		}

		public TimeSpan GetTotalWorked(ushort year, ushort month) {
			throw new NotImplementedException();
		}

		public TimeSpan GetTotalCounted(ushort year, ushort month) {
			throw new NotImplementedException();
		}

		public bool IsClosed(ushort year, ushort month) {
			throw new NotImplementedException();
		}

		public bool IsClosed(ushort year) {
			throw new NotImplementedException();
		}

		public TimeSpan GetTimeLeft(DateTime day) {
			throw new NotImplementedException();
		}

		public XmlDocument GetConfiguration() {
			throw new NotImplementedException();
		}

		#endregion

		public IDataProvider<JobInfo> Work = new SimpleDataProvider<JobInfo>();

		public void Save() {
			Work.Save();
		}

		private void Calc(List<Day> days) => days.ForEach(Calc);

		private void Calc(Day day) {
			//var isLunch = day.IsWorkday && day.WorkList.Any(l => day.Lunch.IsInclude(l));
		}
	}

	public interface IDataProvider<T> where T : class {
		T Data { get; }

		bool Load();

		bool Save();
	}

	public class SimpleDataProvider<T> : IDataProvider<T> where T : class {
		private static string _fileName;

		public T Data { get; private set; }

		public bool Load() {
			var serializer = new XmlSerializer(typeof(T));

			if (!File.Exists(_fileName)) return false;

			try {
				using (var f = new StreamReader(_fileName))
					Data = (T) serializer.Deserialize(f);
			} catch (Exception) {
				return false;
			}

			return true;
		}

		public bool Save() {
			var serializer = new XmlSerializer(typeof(T));

			try {
				using (var f = new StreamWriter(_fileName))
					serializer.Serialize(f, Data);
			} catch (Exception) {
				return false;
			}

			return true;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Object"/> class.
		/// </summary>
		public SimpleDataProvider() {
			_fileName = typeof(T).Name + ".xml";

			if (!Load()) Data = CreateDefault();
		}

		private static T CreateDefault() {
			var ctor = typeof(T).GetConstructor(Type.EmptyTypes);
			return ctor?.Invoke(null) as T;
		}
	}
}