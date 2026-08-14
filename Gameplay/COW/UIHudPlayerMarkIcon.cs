using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200226E")]
public class UIHudPlayerMarkIcon : MonoBehaviour
{
	[Token(Token = "0x400D73C")]
	[FieldOffset(Offset = "0xC")]
	public UISprite m_Icon;

	[Token(Token = "0x400D73D")]
	[FieldOffset(Offset = "0x10")]
	public UILabel m_PlayerTeamIndex;

	[Token(Token = "0x400D73E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject m_EnemyIcon;

	[Token(Token = "0x400D73F")]
	[FieldOffset(Offset = "0x18")]
	public Transform m_ScaleRoot;

	[Token(Token = "0x600BC04")]
	[Address(RVA = "0x1866D0C", Offset = "0x1866D0C", VA = "0x1866D0C")]
	public UIHudPlayerMarkIcon()
	{
	}

	[Token(Token = "0x600BC05")]
	[Address(RVA = "0x1866D14", Offset = "0x1866D14", VA = "0x1866D14")]
	public void SetInfo(int playerTeamIndex, uint posType = 0u)
	{
	}

	[Token(Token = "0x600BC06")]
	[Address(RVA = "0x1866F4C", Offset = "0x1866F4C", VA = "0x1866F4C")]
	public void SetScale(float scale)
	{
	}
}
