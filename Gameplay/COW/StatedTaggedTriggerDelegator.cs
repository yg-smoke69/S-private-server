using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200080B")]
public abstract class StatedTaggedTriggerDelegator : TriggerDelegator
{
	[Token(Token = "0x40050AE")]
	[FieldOffset(Offset = "0x18")]
	private List<int> m_WithinTriggers;

	[Token(Token = "0x40050AF")]
	[FieldOffset(Offset = "0x1C")]
	public Action OnEnterState;

	[Token(Token = "0x40050B0")]
	[FieldOffset(Offset = "0x20")]
	public Action OnExitState;

	[Token(Token = "0x170003C2")]
	public bool IsInTriggers
	{
		[Token(Token = "0x6003350")]
		[Address(RVA = "0x288E2E4", Offset = "0x288E2E4", VA = "0x288E2E4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600334F")]
	[Address(RVA = "0x288E258", Offset = "0x288E258", VA = "0x288E258")]
	protected StatedTaggedTriggerDelegator()
	{
	}

	[Token(Token = "0x6003351")]
	[Address(RVA = "0x288E3B4", Offset = "0x288E3B4", VA = "0x288E3B4", Slot = "5")]
	protected override void OnEnterTriggerChecked(Collider other)
	{
	}

	[Token(Token = "0x6003352")]
	[Address(RVA = "0x288E5E8", Offset = "0x288E5E8", VA = "0x288E5E8", Slot = "6")]
	protected override void OnExitTriggerChecked(Collider other)
	{
	}

	[Token(Token = "0x6003353")]
	[Address(RVA = "0x288E4E8", Offset = "0x288E4E8", VA = "0x288E4E8")]
	private void CallActionForCount(Action a, int i)
	{
	}

	[Token(Token = "0x6003354")]
	[Address(RVA = "0x288E71C", Offset = "0x288E71C", VA = "0x288E71C")]
	public void Clear()
	{
	}

	[Token(Token = "0x6003355")]
	[Address(RVA = "0x288E7DC", Offset = "0x288E7DC", VA = "0x288E7DC")]
	public void _003C_003EiFixBaseProxy_OnEnterTriggerChecked(Collider P0)
	{
	}

	[Token(Token = "0x6003356")]
	[Address(RVA = "0x288E7E4", Offset = "0x288E7E4", VA = "0x288E7E4")]
	public void _003C_003EiFixBaseProxy_OnExitTriggerChecked(Collider P0)
	{
	}
}
