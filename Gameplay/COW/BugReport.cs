using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003AD8")]
public static class BugReport
{
	[Token(Token = "0x2003AD9")]
	private interface IBugReporter
	{
		[Token(Token = "0x170016F1")]
		bool IsInited
		{
			[Token(Token = "0x60174D4")]
			get;
		}

		[Token(Token = "0x60174D5")]
		void Init();

		[Token(Token = "0x60174D6")]
		void SetUnityLogTypes(int logTypes);

		[Token(Token = "0x60174D7")]
		void OverrideUnityLogTypes(int logTypes);

		[Token(Token = "0x60174D8")]
		void SetUserId(string userId);

		[Token(Token = "0x60174D9")]
		void SetKeyValue(string key, string value);

		[Token(Token = "0x60174DA")]
		void Record(string msg);

		[Token(Token = "0x60174DB")]
		void Report(string src, string msg, string stacktrace);

		[Token(Token = "0x60174DC")]
		void Report(Exception exception);
	}

	[Token(Token = "0x2003ADA")]
	private class Bugly : _Attribute
	{
		[Token(Token = "0x170016F2")]
		public static bool Enabled
		{
			[Token(Token = "0x60174DE")]
			[Address(RVA = "0x1811744", Offset = "0x1811744", VA = "0x1811744")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170016F3")]
		public bool IsInited
		{
			[Token(Token = "0x60174DF")]
			[Address(RVA = "0x1812A7C", Offset = "0x1812A7C", VA = "0x1812A7C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60174DD")]
		[Address(RVA = "0x181182C", Offset = "0x181182C", VA = "0x181182C")]
		public Bugly()
		{
		}

		[Token(Token = "0x60174E0")]
		[Address(RVA = "0x1812B44", Offset = "0x1812B44", VA = "0x1812B44", Slot = "5")]
		public void Init()
		{
		}

		[Token(Token = "0x60174E1")]
		[Address(RVA = "0x1812D28", Offset = "0x1812D28", VA = "0x1812D28", Slot = "6")]
		public void SetUnityLogTypes(int logTypes)
		{
		}

		[Token(Token = "0x60174E2")]
		[Address(RVA = "0x1812D84", Offset = "0x1812D84", VA = "0x1812D84", Slot = "7")]
		public void OverrideUnityLogTypes(int logTypes)
		{
		}

		[Token(Token = "0x60174E3")]
		[Address(RVA = "0x1812DE0", Offset = "0x1812DE0", VA = "0x1812DE0", Slot = "8")]
		public void SetUserId(string userId)
		{
		}

		[Token(Token = "0x60174E4")]
		[Address(RVA = "0x1812EB4", Offset = "0x1812EB4", VA = "0x1812EB4", Slot = "9")]
		public void SetKeyValue(string key, string value)
		{
		}

		[Token(Token = "0x60174E5")]
		[Address(RVA = "0x1812FA4", Offset = "0x1812FA4", VA = "0x1812FA4", Slot = "10")]
		public void Record(string msg)
		{
		}

		[Token(Token = "0x60174E6")]
		[Address(RVA = "0x1813000", Offset = "0x1813000", VA = "0x1813000", Slot = "11")]
		public void Report(string src, string msg, string stacktrace)
		{
		}

		[Token(Token = "0x60174E7")]
		[Address(RVA = "0x18130F8", Offset = "0x18130F8", VA = "0x18130F8", Slot = "12")]
		public void Report(Exception exception)
		{
		}
	}

	[Token(Token = "0x2003ADB")]
	private class Crashlytics : _Attribute
	{
		[Token(Token = "0x4018FFB")]
		[FieldOffset(Offset = "0x8")]
		private int UnityLogTypes;

		[Token(Token = "0x4018FFC")]
		[FieldOffset(Offset = "0xC")]
		private int OverrideLogTypes;

		[Token(Token = "0x170016F4")]
		public static bool Enabled
		{
			[Token(Token = "0x60174E9")]
			[Address(RVA = "0x1811834", Offset = "0x1811834", VA = "0x1811834")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170016F5")]
		public bool IsInited
		{
			[Token(Token = "0x60174EA")]
			[Address(RVA = "0x181324C", Offset = "0x181324C", VA = "0x181324C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60174E8")]
		[Address(RVA = "0x181188C", Offset = "0x181188C", VA = "0x181188C")]
		public Crashlytics()
		{
		}

		[Token(Token = "0x60174EB")]
		[Address(RVA = "0x18132AC", Offset = "0x18132AC", VA = "0x18132AC", Slot = "5")]
		public void Init()
		{
		}

		[Token(Token = "0x60174EC")]
		[Address(RVA = "0x18134B0", Offset = "0x18134B0", VA = "0x18134B0")]
		private void OnApplicationLogMessageReceived(string logString, string stacktrace, LogType type)
		{
		}

		[Token(Token = "0x60174ED")]
		[Address(RVA = "0x1813450", Offset = "0x1813450", VA = "0x1813450", Slot = "6")]
		public void SetUnityLogTypes(int logTypes)
		{
		}

		[Token(Token = "0x60174EE")]
		[Address(RVA = "0x18135E4", Offset = "0x18135E4", VA = "0x18135E4", Slot = "7")]
		public void OverrideUnityLogTypes(int logTypes)
		{
		}

		[Token(Token = "0x60174EF")]
		[Address(RVA = "0x1813644", Offset = "0x1813644", VA = "0x1813644", Slot = "8")]
		public void SetUserId(string userId)
		{
		}

		[Token(Token = "0x60174F0")]
		[Address(RVA = "0x18136B0", Offset = "0x18136B0", VA = "0x18136B0", Slot = "9")]
		public void SetKeyValue(string key, string value)
		{
		}

		[Token(Token = "0x60174F1")]
		[Address(RVA = "0x1813578", Offset = "0x1813578", VA = "0x1813578", Slot = "10")]
		public void Record(string msg)
		{
		}

		[Token(Token = "0x60174F2")]
		[Address(RVA = "0x1813738", Offset = "0x1813738", VA = "0x1813738", Slot = "11")]
		public void Report(string src, string msg, string stacktrace)
		{
		}

		[Token(Token = "0x60174F3")]
		[Address(RVA = "0x1813848", Offset = "0x1813848", VA = "0x1813848", Slot = "12")]
		public void Report(Exception exception)
		{
		}

		[Token(Token = "0x60174F4")]
		[Address(RVA = "0x18138B4", Offset = "0x18138B4", VA = "0x18138B4")]
		private void _003CInit_003Em__0()
		{
		}
	}

	[Token(Token = "0x4018FF9")]
	[FieldOffset(Offset = "0x0")]
	private static bool _003CIsInited_003Ek__BackingField;

	[Token(Token = "0x4018FFA")]
	[FieldOffset(Offset = "0x4")]
	private static List<IBugReporter> _Impls;

	[Token(Token = "0x170016EF")]
	public static bool Enabled
	{
		[Token(Token = "0x60174C8")]
		[Address(RVA = "0x18111A0", Offset = "0x18111A0", VA = "0x18111A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016F0")]
	public static bool IsInited
	{
		[Token(Token = "0x60174C9")]
		[Address(RVA = "0x18111F0", Offset = "0x18111F0", VA = "0x18111F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60174CA")]
		[Address(RVA = "0x181127C", Offset = "0x181127C", VA = "0x181127C")]
		private set
		{
		}
	}

	[Token(Token = "0x60174CB")]
	[Address(RVA = "0x181130C", Offset = "0x181130C", VA = "0x181130C")]
	public static void Init()
	{
	}

	[Token(Token = "0x60174CC")]
	[Address(RVA = "0x181189C", Offset = "0x181189C", VA = "0x181189C")]
	public static void SetUnityLogTypes(int logTypes)
	{
	}

	[Token(Token = "0x60174CD")]
	[Address(RVA = "0x1811AF8", Offset = "0x1811AF8", VA = "0x1811AF8")]
	public static void OverrideUnityLogTypes(int logTypes)
	{
	}

	[Token(Token = "0x60174CE")]
	[Address(RVA = "0x1811D54", Offset = "0x1811D54", VA = "0x1811D54")]
	public static void SetUserId(string userId)
	{
	}

	[Token(Token = "0x60174CF")]
	[Address(RVA = "0x1811FB0", Offset = "0x1811FB0", VA = "0x1811FB0")]
	public static void SetKeyValue(string key, string value)
	{
	}

	[Token(Token = "0x60174D0")]
	[Address(RVA = "0x18122C4", Offset = "0x18122C4", VA = "0x18122C4")]
	public static void Log(string msg)
	{
	}

	[Token(Token = "0x60174D1")]
	[Address(RVA = "0x1812520", Offset = "0x1812520", VA = "0x1812520")]
	public static void Report(string source, string msg, string stacktrace)
	{
	}

	[Token(Token = "0x60174D2")]
	[Address(RVA = "0x1812790", Offset = "0x1812790", VA = "0x1812790")]
	public static void Report(Exception exception)
	{
	}
}
