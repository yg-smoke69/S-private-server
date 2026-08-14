using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x2000619")]
public class LevelEscortBossMovePlatform : LevelMovePlatform
{
	[Token(Token = "0x200061A")]
	public enum NOEIGHHHBGG
	{
		[Token(Token = "0x40045DC")]
		Front,
		[Token(Token = "0x40045DD")]
		Back
	}

	[Token(Token = "0x40045DA")]
	[FieldOffset(Offset = "0x90")]
	public NOEIGHHHBGG m_EscortBossMovePlatformPos;

	[Token(Token = "0x60025BC")]
	[Address(RVA = "0x271C20C", Offset = "0x271C20C", VA = "0x271C20C")]
	public LevelEscortBossMovePlatform()
	{
	}
}
