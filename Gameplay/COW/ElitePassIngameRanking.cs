using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020C6")]
public class ElitePassIngameRanking : MonoBehaviour
{
	[Token(Token = "0x400CD32")]
	[FieldOffset(Offset = "0xC")]
	public UILabel m_Nickname;

	[Token(Token = "0x400CD33")]
	[FieldOffset(Offset = "0x10")]
	public UILabel m_BadgeCount;

	[Token(Token = "0x400CD34")]
	[FieldOffset(Offset = "0x14")]
	public UISprite m_IconSprite;

	[Token(Token = "0x400CD35")]
	[FieldOffset(Offset = "0x18")]
	public UISprite m_PinIcon;

	[Token(Token = "0x400CD36")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject m_CelebrityEffect;

	[Token(Token = "0x600A95C")]
	[Address(RVA = "0x252F8C8", Offset = "0x252F8C8", VA = "0x252F8C8")]
	public ElitePassIngameRanking()
	{
	}

	[Token(Token = "0x600A95D")]
	[Address(RVA = "0x252F8D0", Offset = "0x252F8D0", VA = "0x252F8D0")]
	public void SetData(string name, string count, CSSharedItemData itData, uint pinId = 0u, bool isCelebrity = false, bool useSpriteText = false)
	{
	}
}
