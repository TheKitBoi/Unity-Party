// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatCommon
{
	public class LogEventParamPair : ISettable
	{
		public LogEventParamPairParamValue ParamValue { get; set; }

		internal void Set(LogEventParamPairInternal? other)
		{
			if (other != null)
			{
				ParamValue = other.Value.ParamValue;
			}
		}

		public void Set(object other)
		{
			Set(other as LogEventParamPairInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LogEventParamPairInternal : ISettable, System.IDisposable
	{
		private LogEventParamPairParamValueInternal m_ParamValue;

		public LogEventParamPairParamValue ParamValue
		{
			get
			{
				LogEventParamPairParamValue value;
				Helper.TryMarshalGet(m_ParamValue, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_ParamValue, value);
			}
		}

		public void Set(LogEventParamPair other)
		{
			if (other != null)
			{
				ParamValue = other.ParamValue;
			}
		}

		public void Set(object other)
		{
			Set(other as LogEventParamPair);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_ParamValue);
		}
	}
}