using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;
using tcp;

namespace COW;

[Token(Token = "0x200327B")]
public class UIModelUGCDebugger : UIBaseModel
{
	[Token(Token = "0x200327C")]
	public class VariableValue
	{
		[Token(Token = "0x40133D8")]
		[FieldOffset(Offset = "0x8")]
		public string Name;

		[Token(Token = "0x40133D9")]
		[FieldOffset(Offset = "0xC")]
		public string Value;

		[Token(Token = "0x40133DA")]
		[FieldOffset(Offset = "0x10")]
		public int ValueType;

		[Token(Token = "0x60154C8")]
		[Address(RVA = "0x1699784", Offset = "0x1699784", VA = "0x1699784")]
		public VariableValue()
		{
		}
	}

	[Token(Token = "0x200327D")]
	public class DebuggerContext
	{
		[Token(Token = "0x40133DB")]
		[FieldOffset(Offset = "0x8")]
		public int ContextID;

		[Token(Token = "0x40133DC")]
		[FieldOffset(Offset = "0xC")]
		public string HitCodeID;

		[Token(Token = "0x40133DD")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, VariableValue> StackVariable;

		[Token(Token = "0x40133DE")]
		[FieldOffset(Offset = "0x14")]
		public List<VariableValue> CodeParamVariable;

		[Token(Token = "0x60154C9")]
		[Address(RVA = "0x1696694", Offset = "0x1696694", VA = "0x1696694")]
		public DebuggerContext()
		{
		}

		[Token(Token = "0x60154CA")]
		[Address(RVA = "0x1696A38", Offset = "0x1696A38", VA = "0x1696A38")]
		public void UpdateVariableValue(List<string> varNames, List<string> varValues, List<sbyte> varTypes, Dictionary<string, VariableValue> watch)
		{
		}

		[Token(Token = "0x60154CB")]
		[Address(RVA = "0x1696F28", Offset = "0x1696F28", VA = "0x1696F28")]
		public void UpdateCodeParamValue(List<string> varValues, List<sbyte> varTypes)
		{
		}

		[Token(Token = "0x60154CC")]
		[Address(RVA = "0x169978C", Offset = "0x169978C", VA = "0x169978C")]
		public VariableValue GetStackVariableValue(string variableName)
		{
			return null;
		}
	}

	[Token(Token = "0x200327E")]
	public class BreakpointStatus
	{
		[Token(Token = "0x40133DF")]
		[FieldOffset(Offset = "0x8")]
		public string CodeID;

		[Token(Token = "0x40133E0")]
		[FieldOffset(Offset = "0xC")]
		public bool IsEnable;

		[Token(Token = "0x60154CD")]
		[Address(RVA = "0x169515C", Offset = "0x169515C", VA = "0x169515C")]
		public BreakpointStatus()
		{
		}
	}

	[Token(Token = "0x200327F")]
	public enum LogDataType
	{
		[Token(Token = "0x40133E2")]
		LOGGER_CHANNEL_DEFAULT,
		[Token(Token = "0x40133E3")]
		LOGGER_CHANNEL_DEBUG,
		[Token(Token = "0x40133E4")]
		LOGGER_CHANNEL_INFO,
		[Token(Token = "0x40133E5")]
		LOGGER_CHANNEL_WARNING,
		[Token(Token = "0x40133E6")]
		LOGGER_CHANNEL_ERROR,
		[Token(Token = "0x40133E7")]
		LOGGER_CHANNEL_NUM
	}

	[Token(Token = "0x2003280")]
	public class LogData
	{
		[Token(Token = "0x40133E8")]
		[FieldOffset(Offset = "0x8")]
		public int LogType;

		[Token(Token = "0x40133E9")]
		[FieldOffset(Offset = "0xC")]
		public string CodeID;

		[Token(Token = "0x40133EA")]
		[FieldOffset(Offset = "0x10")]
		public string LogText;

		[Token(Token = "0x40133EB")]
		[FieldOffset(Offset = "0x14")]
		public int LogLocTextID;

		[Token(Token = "0x40133EC")]
		[FieldOffset(Offset = "0x18")]
		public long TimeUTC;

		[Token(Token = "0x60154CE")]
		[Address(RVA = "0x1697DF0", Offset = "0x1697DF0", VA = "0x1697DF0")]
		public LogData()
		{
		}
	}

	[Token(Token = "0x40133CC")]
	[FieldOffset(Offset = "0xC")]
	public Dictionary<string, VariableValue> VariableWatch;

	[Token(Token = "0x40133CD")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, BreakpointStatus> m_localBreakPoints;

	[Token(Token = "0x40133CE")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, BreakpointStatus> m_breakPoints;

	[Token(Token = "0x40133CF")]
	[FieldOffset(Offset = "0x18")]
	private List<DebuggerContext> m_debuggerContextList;

	[Token(Token = "0x40133D0")]
	[FieldOffset(Offset = "0x1C")]
	private int m_currentDebuggerContext;

	[Token(Token = "0x40133D1")]
	[FieldOffset(Offset = "0x20")]
	private bool m_debugEnabled;

	[Token(Token = "0x40133D2")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<string, KDNPLMHKBHC> CodeIDCache;

	[Token(Token = "0x40133D3")]
	[FieldOffset(Offset = "0x28")]
	public List<LogData> AllLogs;

	[Token(Token = "0x40133D4")]
	[FieldOffset(Offset = "0x2C")]
	private float m_beginDebugTimeThisTime;

	[Token(Token = "0x40133D5")]
	[FieldOffset(Offset = "0x30")]
	private uint m_totalDebugCountThisTime;

	[Token(Token = "0x40133D6")]
	[FieldOffset(Offset = "0x34")]
	private float m_totalDebugTimeThisTime;

	[Token(Token = "0x40133D7")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x17001674")]
	public Dictionary<string, BreakpointStatus> BreakPoints
	{
		[Token(Token = "0x60154A6")]
		[Address(RVA = "0x1694D9C", Offset = "0x1694D9C", VA = "0x1694D9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001675")]
	public Dictionary<string, BreakpointStatus> LocalBreakPoints
	{
		[Token(Token = "0x60154A7")]
		[Address(RVA = "0x1694DF4", Offset = "0x1694DF4", VA = "0x1694DF4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001676")]
	public List<DebuggerContext> AllDebuggerContext
	{
		[Token(Token = "0x60154A8")]
		[Address(RVA = "0x1694E4C", Offset = "0x1694E4C", VA = "0x1694E4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001677")]
	public int CurrentDebuggerContext
	{
		[Token(Token = "0x60154A9")]
		[Address(RVA = "0x1694EA4", Offset = "0x1694EA4", VA = "0x1694EA4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60154AA")]
		[Address(RVA = "0x1694EFC", Offset = "0x1694EFC", VA = "0x1694EFC")]
		set
		{
		}
	}

	[Token(Token = "0x17001678")]
	public uint TotalDebugCount
	{
		[Token(Token = "0x60154C0")]
		[Address(RVA = "0x1698678", Offset = "0x1698678", VA = "0x1698678")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001679")]
	public uint TotalDebugTime
	{
		[Token(Token = "0x60154C1")]
		[Address(RVA = "0x16986D0", Offset = "0x16986D0", VA = "0x16986D0")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x60154A5")]
	[Address(RVA = "0x1694BFC", Offset = "0x1694BFC", VA = "0x1694BFC")]
	public UIModelUGCDebugger()
	{
	}

	[Token(Token = "0x60154AB")]
	[Address(RVA = "0x1694F5C", Offset = "0x1694F5C", VA = "0x1694F5C")]
	public void AddBreakPoint(string codeID)
	{
	}

	[Token(Token = "0x60154AC")]
	[Address(RVA = "0x1695164", Offset = "0x1695164", VA = "0x1695164")]
	public void ToggleBreakPoint(string codeID, bool isRemove)
	{
	}

	[Token(Token = "0x60154AD")]
	[Address(RVA = "0x1695450", Offset = "0x1695450", VA = "0x1695450")]
	public void Step()
	{
	}

	[Token(Token = "0x60154AE")]
	[Address(RVA = "0x1695760", Offset = "0x1695760", VA = "0x1695760")]
	public void Continue()
	{
	}

	[Token(Token = "0x60154AF")]
	[Address(RVA = "0x1695A28", Offset = "0x1695A28", VA = "0x1695A28")]
	public void Pause()
	{
	}

	[Token(Token = "0x60154B0")]
	[Address(RVA = "0x1695B64", Offset = "0x1695B64", VA = "0x1695B64")]
	public void RequestVariable(List<string> variableNameList)
	{
	}

	[Token(Token = "0x60154B1")]
	[Address(RVA = "0x1695CEC", Offset = "0x1695CEC", VA = "0x1695CEC")]
	public void RequestVariable(DebuggerContext dbgCtx)
	{
	}

	[Token(Token = "0x60154B2")]
	[Address(RVA = "0x1695E8C", Offset = "0x1695E8C", VA = "0x1695E8C")]
	public void ExecGMCmd(LMLCIABMLEK gmCmdID)
	{
	}

	[Token(Token = "0x60154B3")]
	[Address(RVA = "0x1695FB0", Offset = "0x1695FB0", VA = "0x1695FB0")]
	public void OnDebugInformation(List<string> breakPointList)
	{
	}

	[Token(Token = "0x60154B4")]
	[Address(RVA = "0x1696508", Offset = "0x1696508", VA = "0x1696508")]
	public void OnBreakpointHited(int contextID, string hitCodeID)
	{
	}

	[Token(Token = "0x60154B5")]
	[Address(RVA = "0x1696754", Offset = "0x1696754", VA = "0x1696754")]
	public void OnDebuggerContextSuspend(int contextID)
	{
	}

	[Token(Token = "0x60154B6")]
	[Address(RVA = "0x16968E0", Offset = "0x16968E0", VA = "0x16968E0")]
	public void OnVariableResponse(int contextID, List<string> varNames, List<string> varValues, List<sbyte> varTypes)
	{
	}

	[Token(Token = "0x60154B7")]
	[Address(RVA = "0x1696DE4", Offset = "0x1696DE4", VA = "0x1696DE4")]
	public void OnCodeParamValueResponse(int contextID, List<string> varValues, List<sbyte> varTypes)
	{
	}

	[Token(Token = "0x60154B8")]
	[Address(RVA = "0x16971E8", Offset = "0x16971E8", VA = "0x16971E8")]
	public void OnConsoleLog(int logType, string codeID, string logText, long timeutc)
	{
	}

	[Token(Token = "0x60154B9")]
	[Address(RVA = "0x1697DF8", Offset = "0x1697DF8", VA = "0x1697DF8")]
	public void OnNotifyCmd(int cmdID)
	{
	}

	[Token(Token = "0x60154BA")]
	[Address(RVA = "0x16981B8", Offset = "0x16981B8", VA = "0x16981B8")]
	public void OnStopDebug()
	{
	}

	[Token(Token = "0x60154BB")]
	[Address(RVA = "0x16955A4", Offset = "0x16955A4", VA = "0x16955A4")]
	public DebuggerContext GetDebugContextByID(int contextID)
	{
		return null;
	}

	[Token(Token = "0x60154BC")]
	[Address(RVA = "0x16958C8", Offset = "0x16958C8", VA = "0x16958C8")]
	private void RemoveDebugContext(int contextID)
	{
	}

	[Token(Token = "0x60154BD")]
	[Address(RVA = "0x1698368", Offset = "0x1698368", VA = "0x1698368", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60154BE")]
	[Address(RVA = "0x16983C0", Offset = "0x16983C0", VA = "0x16983C0")]
	public bool IsDebuggerActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60154BF")]
	[Address(RVA = "0x16984A4", Offset = "0x16984A4", VA = "0x16984A4")]
	public bool IsDebugSwitchOpened()
	{
		return default(bool);
	}

	[Token(Token = "0x60154C2")]
	[Address(RVA = "0x1698734", Offset = "0x1698734", VA = "0x1698734")]
	public void LogEventClear()
	{
	}

	[Token(Token = "0x60154C3")]
	[Address(RVA = "0x16980EC", Offset = "0x16980EC", VA = "0x16980EC")]
	private void LogEventBeginDebug()
	{
	}

	[Token(Token = "0x60154C4")]
	[Address(RVA = "0x16982D4", Offset = "0x16982D4", VA = "0x16982D4")]
	private void LogEventEndDebug()
	{
	}

	[Token(Token = "0x60154C5")]
	[Address(RVA = "0x169879C", Offset = "0x169879C", VA = "0x169879C")]
	public static UGCDebugStartReq BuildUGCDebugStartReq(bool startFromCurCamera, bool isFillFullBot, bool enableBreakPoints, out DPDCNPLHENA debugSettings)
	{
		return null;
	}

	[Token(Token = "0x60154C6")]
	[Address(RVA = "0x16992C0", Offset = "0x16992C0", VA = "0x16992C0")]
	private static void OnHandleReturnToEdit()
	{
	}

	[Token(Token = "0x60154C7")]
	[Address(RVA = "0x1699460", Offset = "0x1699460", VA = "0x1699460")]
	public static bool ClientStartDebugGame(string serverAdd, ulong serviceRoomID, string secret, uint mapid, uint gamemode, uint groupmode)
	{
		return default(bool);
	}
}
