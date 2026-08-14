using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000609")]
public class LevelDestructibleObject : BaseLevelObject
{
	[Token(Token = "0x400457D")]
	[FieldOffset(Offset = "0x74")]
	private Dictionary<uint, LevelDestructiblePartObject> GMKJBBLFHPF;

	[Token(Token = "0x400457E")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_Model;

	[Token(Token = "0x400457F")]
	[FieldOffset(Offset = "0x7C")]
	public LevelDestructiblePartObject[] parts;

	[Token(Token = "0x4004580")]
	[FieldOffset(Offset = "0x80")]
	private bool ODPILEKNJCL;

	[Token(Token = "0x600252B")]
	[Address(RVA = "0x27107B0", Offset = "0x27107B0", VA = "0x27107B0")]
	public LevelDestructibleObject()
	{
	}

	[Token(Token = "0x600252C")]
	[Address(RVA = "0x271083C", Offset = "0x271083C", VA = "0x271083C", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x600252D")]
	[Address(RVA = "0x2710FCC", Offset = "0x2710FCC", VA = "0x2710FCC", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x600252E")]
	[Address(RVA = "0x2711070", Offset = "0x2711070", VA = "0x2711070", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600252F")]
	[Address(RVA = "0x2711BA8", Offset = "0x2711BA8", VA = "0x2711BA8", Slot = "23")]
	protected override void OnUpdateVisibleStateByStreamer(Vector3 MKGCDPNKMOB, Vector3 OANAHFHPBNB)
	{
	}

	[Token(Token = "0x6002530")]
	[Address(RVA = "0x2711DF0", Offset = "0x2711DF0", VA = "0x2711DF0")]
	private LevelDestructiblePartObject FFJCAALKIIF(uint IDNEFEOPGIF)
	{
		return null;
	}

	[Token(Token = "0x6002531")]
	[Address(RVA = "0x2711ED8", Offset = "0x2711ED8", VA = "0x2711ED8")]
	public void RemoveDestructiblePart(uint IDNEFEOPGIF)
	{
	}

	[Token(Token = "0x6002532")]
	[Address(RVA = "0x2711FA4", Offset = "0x2711FA4", VA = "0x2711FA4")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x6002533")]
	[Address(RVA = "0x2711FAC", Offset = "0x2711FAC", VA = "0x2711FAC")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	[Token(Token = "0x6002534")]
	[Address(RVA = "0x2711FB4", Offset = "0x2711FB4", VA = "0x2711FB4")]
	public void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}
}
