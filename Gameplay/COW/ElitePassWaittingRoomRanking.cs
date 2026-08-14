using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020C7")]
public class ElitePassWaittingRoomRanking : MonoBehaviour
{
	[Token(Token = "0x400CD37")]
	[FieldOffset(Offset = "0xC")]
	public UILabel m_Nickname;

	[Token(Token = "0x400CD38")]
	[FieldOffset(Offset = "0x10")]
	public UILabel m_BadgeCount;

	[Token(Token = "0x400CD39")]
	[FieldOffset(Offset = "0x14")]
	public UISprite m_IconSprite;

	[Token(Token = "0x400CD3A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite m_PinIcon;

	[Token(Token = "0x400CD3B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject m_CelebrityEffect;

	[Token(Token = "0x400CD3C")]
	[FieldOffset(Offset = "0x20")]
	public bool m_FixNamePosition;

	[Token(Token = "0x600A95E")]
	[Address(RVA = "0x2530564", Offset = "0x2530564", VA = "0x2530564")]
	public ElitePassWaittingRoomRanking()
	{
	}

	[Token(Token = "0x600A95F")]
	[Address(RVA = "0x2530574", Offset = "0x2530574", VA = "0x2530574")]
	public void SetData(string name, string count, uint id, uint pinId = 0u, bool isCelebrity = false, bool useSpriteText = false)
	{
	}
}
