using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x200071D")]
public class LevelDefenderPoint : BaseLevelObject
{
	[Token(Token = "0x4004C2A")]
	[FieldOffset(Offset = "0x74")]
	public int m_RoundID;

	[Token(Token = "0x4004C2B")]
	[FieldOffset(Offset = "0x78")]
	public int m_HP;

	[Token(Token = "0x6002D05")]
	[Address(RVA = "0x2710704", Offset = "0x2710704", VA = "0x2710704")]
	public LevelDefenderPoint()
	{
	}

	[Token(Token = "0x6002D06")]
	[Address(RVA = "0x271070C", Offset = "0x271070C", VA = "0x271070C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}
}
