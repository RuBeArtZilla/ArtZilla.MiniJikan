using System;
using System.CodeDom;
using System.Diagnostics;
using System.Xml;

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

	}

	public interface IDataProvider<T> {

	}

	public abstract class SimpleDataProvider<T> : IDataProvider<T> {
		public string Filename { get; set; }

	}

	public struct Working {
		Working(TimeSpan begin) {
			Begin = begin;
			_end = TimeSpan.Zero;
			_duration = TimeSpan.Zero;

			if (begin < TimeSpan.Zero)
				throw new ArgumentException("Start time must be positive", nameof(begin));
		}

		Working(TimeSpan begin, TimeSpan end) : this(begin) {
			if (end < begin)
				throw new ArgumentException("Start time greater than end time.");

			if (end <= TimeSpan.Zero)
				throw new ArgumentException("End time must be positive", nameof(end));

			_end = end;
			_duration = end - begin;
		}

		public TimeSpan Begin { get; }

		public TimeSpan End {
			get {
				if (!_end.HasValue)
					throw new Exception("end time not setted");
				return _end.Value;
			}
		}

		public TimeSpan Duration {
			get {
				if (!_end.HasValue)
					throw new Exception("end time not setted");
				return _duration;
			}
		}

		public void EndWork(TimeSpan end) {
			
		}


		private TimeSpan? _end;
		private TimeSpan _duration;
	}

	public interface IWorktimeProvider {

	}
}