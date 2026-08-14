using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003AA3")]
public class UIHudCSSOTeamInfoView : MonoBehaviour
{
	[Token(Token = "0x4018EFA")]
	[FieldOffset(Offset = "0xC")]
	public UISprite[] m_Sprites;

	[Token(Token = "0x4018EFB")]
	[FieldOffset(Offset = "0x10")]
	public UISprite[] m_Hps;

	[Token(Token = "0x4018EFC")]
	[FieldOffset(Offset = "0x14")]
	public Animation[] m_HpAnims;

	[Token(Token = "0x4018EFD")]
	[FieldOffset(Offset = "0x18")]
	public TweenFill[] m_HpTween;

	[Token(Token = "0x60173A9")]
	[Address(RVA = "0x2137764", Offset = "0x2137764", VA = "0x2137764")]
	public UIHudCSSOTeamInfoView()
	{
	}

	[Token(Token = "0x60173AA")]
	[Address(RVA = "0x212DB94", Offset = "0x212DB94", VA = "0x212DB94")]
	public void SetColor(Color c)
	{
	}

	[Token(Token = "0x60173AB")]
	[Address(RVA = "0x212DD68", Offset = "0x212DD68", VA = "0x212DD68")]
	public void SetHp(byte hp)
	{
	}

	[Token(Token = "0x60173AC")]
	[Address(RVA = "0x2134EFC", Offset = "0x2134EFC", VA = "0x2134EFC")]
	public void ShowHpAnim(byte lastRoundHp, byte currHp)
	{
	}
}
