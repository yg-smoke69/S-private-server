using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000624")]
public class LevelFlagBattleScoreRegion : BaseLevelObject
{
	[Token(Token = "0x4004618")]
	[FieldOffset(Offset = "0x74")]
	public float m_Width;

	[Token(Token = "0x4004619")]
	[FieldOffset(Offset = "0x78")]
	public float m_Length;

	[Token(Token = "0x400461A")]
	[FieldOffset(Offset = "0x7C")]
	public int m_Region;

	[Token(Token = "0x400461B")]
	[FieldOffset(Offset = "0x80")]
	public Color m_Color;

	[Token(Token = "0x60025F6")]
	[Address(RVA = "0x27222C8", Offset = "0x27222C8", VA = "0x27222C8")]
	public LevelFlagBattleScoreRegion()
	{
	}

	[Token(Token = "0x60025F7")]
	[Address(RVA = "0x272232C", Offset = "0x272232C", VA = "0x272232C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}
}
