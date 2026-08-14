using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x2000AB3")]
internal class DestructiblePartObject : AttackableEntity
{
	[Token(Token = "0x4005D64")]
	[FieldOffset(Offset = "0x48")]
	private LevelDestructiblePartObject JJFIIOENAKD;

	[Token(Token = "0x60051C9")]
	[Address(RVA = "0x1754348", Offset = "0x1754348", VA = "0x1754348")]
	public DestructiblePartObject()
	{
	}

	[Token(Token = "0x60051CA")]
	[Address(RVA = "0x1754350", Offset = "0x1754350", VA = "0x1754350", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60051CB")]
	[Address(RVA = "0x175442C", Offset = "0x175442C", VA = "0x175442C")]
	public void SetLevelObject(LevelDestructiblePartObject JNIEHFIMNAL)
	{
	}

	[Token(Token = "0x60051CC")]
	[Address(RVA = "0x175448C", Offset = "0x175448C", VA = "0x175448C", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60051CD")]
	[Address(RVA = "0x17544E4", Offset = "0x17544E4", VA = "0x17544E4", Slot = "59")]
	public override uint GetAttackableID()
	{
		return default(uint);
	}

	[Token(Token = "0x60051CE")]
	[Address(RVA = "0x175455C", Offset = "0x175455C", VA = "0x175455C", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint EMFANFHKAMM = 0u)
	{
	}

	[Token(Token = "0x60051CF")]
	[Address(RVA = "0x1754924", Offset = "0x1754924", VA = "0x1754924")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x60051D0")]
	[Address(RVA = "0x175492C", Offset = "0x175492C", VA = "0x175492C")]
	public uint _003C_003EiFixBaseProxy_GetAttackableID()
	{
		return default(uint);
	}

	[Token(Token = "0x60051D1")]
	[Address(RVA = "0x1754934", Offset = "0x1754934", VA = "0x1754934")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
