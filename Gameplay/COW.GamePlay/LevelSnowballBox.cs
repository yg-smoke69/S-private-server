using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x200069D")]
public class LevelSnowballBox : BaseLevelObject
{
	[Token(Token = "0x40048CA")]
	[FieldOffset(Offset = "0x74")]
	public uint DataID;

	[Token(Token = "0x6002A75")]
	[Address(RVA = "0x20D0364", Offset = "0x20D0364", VA = "0x20D0364")]
	public LevelSnowballBox()
	{
	}

	[Token(Token = "0x6002A76")]
	[Address(RVA = "0x20D036C", Offset = "0x20D036C", VA = "0x20D036C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002A77")]
	[Address(RVA = "0x20D0410", Offset = "0x20D0410", VA = "0x20D0410", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002A78")]
	[Address(RVA = "0x20D04A4", Offset = "0x20D04A4", VA = "0x20D04A4")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}
}
