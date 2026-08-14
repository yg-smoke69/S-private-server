using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200400C")]
public class TimerAction : Timer, _Attribute
{
	[Token(Token = "0x401AF02")]
	[FieldOffset(Offset = "0xC")]
	private Action m_Action;

	[Token(Token = "0x401AF03")]
	[FieldOffset(Offset = "0x10")]
	private bool m_IsRepeated;

	[Token(Token = "0x401AF04")]
	[FieldOffset(Offset = "0x14")]
	private float m_Duration;

	[Token(Token = "0x401AF05")]
	[FieldOffset(Offset = "0x18")]
	private bool m_IsInPool;

	[Token(Token = "0x601A14A")]
	[Address(RVA = "0x323D7E8", Offset = "0x323D7E8", VA = "0x323D7E8")]
	public TimerAction()
	{
	}

	[Token(Token = "0x601A14B")]
	[Address(RVA = "0x323D7F8", Offset = "0x323D7F8", VA = "0x323D7F8")]
	public void SetActionAt(float gameTime, float expiredTime, Action action, bool isRepeated)
	{
	}

	[Token(Token = "0x601A14C")]
	[Address(RVA = "0x323D81C", Offset = "0x323D81C", VA = "0x323D81C")]
	public void ChangeExpireTime(float deltaExpiredTime)
	{
	}

	[Token(Token = "0x601A14D")]
	[Address(RVA = "0x323D830", Offset = "0x323D830", VA = "0x323D830")]
	public void MoveFront()
	{
	}

	[Token(Token = "0x601A14E")]
	[Address(RVA = "0x323D83C", Offset = "0x323D83C", VA = "0x323D83C")]
	public bool Update(float gameTime, uint actionId, Dictionary<uint, Action> timerActionsToBeCalled)
	{
		return default(bool);
	}

	[Token(Token = "0x601A14F")]
	[Address(RVA = "0x323D930", Offset = "0x323D930", VA = "0x323D930", Slot = "4")]
	public void OnAllocated()
	{
	}

	[Token(Token = "0x601A150")]
	[Address(RVA = "0x323D93C", Offset = "0x323D93C", VA = "0x323D93C", Slot = "5")]
	public void OnCollected()
	{
	}

	[Token(Token = "0x601A151")]
	[Address(RVA = "0x323D964", Offset = "0x323D964", VA = "0x323D964", Slot = "6")]
	public bool IsInPool()
	{
		return default(bool);
	}
}
