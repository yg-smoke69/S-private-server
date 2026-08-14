using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003F28")]
public class ConditionAction : _Attribute
{
	[Token(Token = "0x2003F29")]
	public delegate bool ActionHandler();

	[Token(Token = "0x2003F2A")]
	public delegate bool ConditionHandler();

	[Token(Token = "0x2003F2B")]
	public enum State
	{
		[Token(Token = "0x401AA2F")]
		Active,
		[Token(Token = "0x401AA30")]
		DeActive
	}

	[Token(Token = "0x2003F2C")]
	private sealed class _003CWhenAfterTime_003Ec__AnonStorey0
	{
		[Token(Token = "0x401AA31")]
		[FieldOffset(Offset = "0x8")]
		internal float startTime;

		[Token(Token = "0x401AA32")]
		[FieldOffset(Offset = "0xC")]
		internal float durationSecond;

		[Token(Token = "0x6019B75")]
		[Address(RVA = "0x308911C", Offset = "0x308911C", VA = "0x308911C")]
		public _003CWhenAfterTime_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6019B76")]
		[Address(RVA = "0x3089488", Offset = "0x3089488", VA = "0x3089488")]
		internal bool _003C_003Em__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003F2D")]
	private sealed class _003CWhenIntervalTime_003Ec__AnonStorey1
	{
		[Token(Token = "0x401AA33")]
		[FieldOffset(Offset = "0x8")]
		internal float startTime;

		[Token(Token = "0x401AA34")]
		[FieldOffset(Offset = "0xC")]
		internal float intervalSecond;

		[Token(Token = "0x6019B77")]
		[Address(RVA = "0x308923C", Offset = "0x308923C", VA = "0x308923C")]
		public _003CWhenIntervalTime_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6019B78")]
		[Address(RVA = "0x30894C4", Offset = "0x30894C4", VA = "0x30894C4")]
		internal bool _003C_003Em__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003F2E")]
	private sealed class _003CCancelWhenAfterTime_003Ec__AnonStorey2
	{
		[Token(Token = "0x401AA35")]
		[FieldOffset(Offset = "0x8")]
		internal float startTime;

		[Token(Token = "0x401AA36")]
		[FieldOffset(Offset = "0xC")]
		internal float durationSecond;

		[Token(Token = "0x6019B79")]
		[Address(RVA = "0x30893D4", Offset = "0x30893D4", VA = "0x30893D4")]
		public _003CCancelWhenAfterTime_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6019B7A")]
		[Address(RVA = "0x308944C", Offset = "0x308944C", VA = "0x308944C")]
		internal bool _003C_003Em__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401AA25")]
	[FieldOffset(Offset = "0x0")]
	private static int GUID_INDEX;

	[Token(Token = "0x401AA26")]
	[FieldOffset(Offset = "0x8")]
	private ActionHandler m_actionHandler;

	[Token(Token = "0x401AA27")]
	[FieldOffset(Offset = "0xC")]
	private List<ConditionHandler> m_actionConditionHandlers;

	[Token(Token = "0x401AA28")]
	[FieldOffset(Offset = "0x10")]
	private List<ConditionHandler> m_cancelConditionHandlers;

	[Token(Token = "0x401AA29")]
	[FieldOffset(Offset = "0x14")]
	private State _003Cstate_003Ek__BackingField;

	[Token(Token = "0x401AA2A")]
	[FieldOffset(Offset = "0x18")]
	private int _003CGUID_003Ek__BackingField;

	[Token(Token = "0x401AA2B")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_IsInPool;

	[Token(Token = "0x401AA2C")]
	[FieldOffset(Offset = "0x20")]
	private float m_lastCheckConditionTime;

	[Token(Token = "0x401AA2D")]
	[FieldOffset(Offset = "0x24")]
	private float m_checkConditionInterval;

	[Token(Token = "0x17001C1E")]
	public State state
	{
		[Token(Token = "0x6019B5C")]
		[Address(RVA = "0x3088748", Offset = "0x3088748", VA = "0x3088748")]
		get
		{
			return default(State);
		}
		[Token(Token = "0x6019B5D")]
		[Address(RVA = "0x3088750", Offset = "0x3088750", VA = "0x3088750")]
		private set
		{
		}
	}

	[Token(Token = "0x17001C1F")]
	public int GUID
	{
		[Token(Token = "0x6019B5E")]
		[Address(RVA = "0x3088758", Offset = "0x3088758", VA = "0x3088758")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6019B5F")]
		[Address(RVA = "0x3088760", Offset = "0x3088760", VA = "0x3088760")]
		private set
		{
		}
	}

	[Token(Token = "0x6019B5B")]
	[Address(RVA = "0x3088694", Offset = "0x3088694", VA = "0x3088694")]
	public ConditionAction()
	{
	}

	[Token(Token = "0x6019B60")]
	[Address(RVA = "0x3088768", Offset = "0x3088768", VA = "0x3088768", Slot = "4")]
	public void OnAllocated()
	{
	}

	[Token(Token = "0x6019B61")]
	[Address(RVA = "0x3088820", Offset = "0x3088820", VA = "0x3088820", Slot = "5")]
	public void OnCollected()
	{
	}

	[Token(Token = "0x6019B62")]
	[Address(RVA = "0x30888F0", Offset = "0x30888F0", VA = "0x30888F0", Slot = "6")]
	public bool IsInPool()
	{
		return default(bool);
	}

	[Token(Token = "0x6019B63")]
	[Address(RVA = "0x30888F8", Offset = "0x30888F8", VA = "0x30888F8")]
	public void RunOneFrame()
	{
	}

	[Token(Token = "0x6019B64")]
	[Address(RVA = "0x307C60C", Offset = "0x307C60C", VA = "0x307C60C")]
	public ConditionAction SetAction(ActionHandler callbackActionHandler)
	{
		return null;
	}

	[Token(Token = "0x6019B65")]
	[Address(RVA = "0x3088F8C", Offset = "0x3088F8C", VA = "0x3088F8C")]
	public ConditionAction When(ConditionHandler conditionHandler)
	{
		return null;
	}

	[Token(Token = "0x6019B66")]
	[Address(RVA = "0x3089018", Offset = "0x3089018", VA = "0x3089018")]
	public ConditionAction WhenAfterTime(float durationSecond)
	{
		return null;
	}

	[Token(Token = "0x6019B67")]
	[Address(RVA = "0x3089138", Offset = "0x3089138", VA = "0x3089138")]
	public ConditionAction WhenIntervalTime(float intervalSecond)
	{
		return null;
	}

	[Token(Token = "0x6019B68")]
	[Address(RVA = "0x3089244", Offset = "0x3089244", VA = "0x3089244")]
	public ConditionAction CancelWhen(ConditionHandler conditionHandler)
	{
		return null;
	}

	[Token(Token = "0x6019B69")]
	[Address(RVA = "0x30892D0", Offset = "0x30892D0", VA = "0x30892D0")]
	public ConditionAction CancelWhenAfterTime(float durationSecond)
	{
		return null;
	}

	[Token(Token = "0x6019B6A")]
	[Address(RVA = "0x30893DC", Offset = "0x30893DC", VA = "0x30893DC")]
	public ConditionAction CheckConditionInterval(float intervalSecond)
	{
		return null;
	}

	[Token(Token = "0x6019B6B")]
	[Address(RVA = "0x3088B58", Offset = "0x3088B58", VA = "0x3088B58")]
	public void Cancel()
	{
	}
}
