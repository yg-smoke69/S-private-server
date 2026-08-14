using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x200069B")]
public class LevelSkyFalling : BaseLevelObject
{
	[Token(Token = "0x40048C7")]
	[FieldOffset(Offset = "0x74")]
	public uint HSpeed;

	[Token(Token = "0x40048C8")]
	[FieldOffset(Offset = "0x78")]
	public uint VSpeed;

	[Token(Token = "0x6002A64")]
	[Address(RVA = "0x20CFC74", Offset = "0x20CFC74", VA = "0x20CFC74")]
	public LevelSkyFalling()
	{
	}

	[Token(Token = "0x6002A65")]
	[Address(RVA = "0x20CFC7C", Offset = "0x20CFC7C", VA = "0x20CFC7C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}
}
