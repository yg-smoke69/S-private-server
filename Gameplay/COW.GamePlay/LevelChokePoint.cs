using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005F1")]
public class LevelChokePoint : BaseLevelObject
{
	[Token(Token = "0x40044CF")]
	[FieldOffset(Offset = "0x74")]
	private Collider NNKIAHLOJMH;

	[Token(Token = "0x40044D0")]
	[FieldOffset(Offset = "0x78")]
	public Transform ModelContainer;

	[Token(Token = "0x40044D1")]
	[FieldOffset(Offset = "0x7C")]
	private bool NKLPHGGGMFI;

	[Token(Token = "0x40044D2")]
	[FieldOffset(Offset = "0x80")]
	private ResourceID ANJLBIOKEAO;

	[Token(Token = "0x40044D3")]
	[FieldOffset(Offset = "0x84")]
	private bool LKHJCBMAPGB;

	[Token(Token = "0x6002442")]
	[Address(RVA = "0x2383754", Offset = "0x2383754", VA = "0x2383754")]
	public LevelChokePoint()
	{
	}

	[Token(Token = "0x6002443")]
	[Address(RVA = "0x23837CC", Offset = "0x23837CC", VA = "0x23837CC", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002444")]
	[Address(RVA = "0x2383910", Offset = "0x2383910", VA = "0x2383910", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002445")]
	[Address(RVA = "0x23839B4", Offset = "0x23839B4", VA = "0x23839B4", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002446")]
	[Address(RVA = "0x2383B40", Offset = "0x2383B40", VA = "0x2383B40", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002447")]
	[Address(RVA = "0x2383B98", Offset = "0x2383B98", VA = "0x2383B98")]
	private void ECNMLKICCAH(bool JGLJDJFHPBO, bool DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002448")]
	[Address(RVA = "0x2383DDC", Offset = "0x2383DDC", VA = "0x2383DDC")]
	private void KMJODBHMEGM()
	{
	}

	[Token(Token = "0x6002449")]
	[Address(RVA = "0x23840B8", Offset = "0x23840B8", VA = "0x23840B8", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600244A")]
	[Address(RVA = "0x2384290", Offset = "0x2384290", VA = "0x2384290")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x600244B")]
	[Address(RVA = "0x2384298", Offset = "0x2384298", VA = "0x2384298")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x600244C")]
	[Address(RVA = "0x23842A0", Offset = "0x23842A0", VA = "0x23842A0")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x600244D")]
	[Address(RVA = "0x23842A8", Offset = "0x23842A8", VA = "0x23842A8")]
	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}
}
