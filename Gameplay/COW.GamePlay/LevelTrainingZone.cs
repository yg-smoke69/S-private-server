using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x20006C1")]
public class LevelTrainingZone : BaseLevelObject
{
	[Token(Token = "0x4004AB1")]
	[FieldOffset(Offset = "0x74")]
	public IHJOFJKFIBB ZoneType;

	[Token(Token = "0x6002B5D")]
	[Address(RVA = "0x242720C", Offset = "0x242720C", VA = "0x242720C")]
	public LevelTrainingZone()
	{
	}

	[Token(Token = "0x6002B5E")]
	[Address(RVA = "0x242721C", Offset = "0x242721C", VA = "0x242721C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}
}
