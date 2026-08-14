using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x20005D6")]
public class LevelAmmoBox : BaseLevelObject
{
	[Token(Token = "0x4004418")]
	[FieldOffset(Offset = "0x74")]
	public int ItemID;

	[Token(Token = "0x4004419")]
	[FieldOffset(Offset = "0x78")]
	public int ItemCount;

	[Token(Token = "0x600233D")]
	[Address(RVA = "0x17D6140", Offset = "0x17D6140", VA = "0x17D6140")]
	public LevelAmmoBox()
	{
	}

	[Token(Token = "0x600233E")]
	[Address(RVA = "0x17D6148", Offset = "0x17D6148", VA = "0x17D6148", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600233F")]
	[Address(RVA = "0x17D6408", Offset = "0x17D6408", VA = "0x17D6408", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002340")]
	[Address(RVA = "0x17D64AC", Offset = "0x17D64AC", VA = "0x17D64AC")]
	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}
}
