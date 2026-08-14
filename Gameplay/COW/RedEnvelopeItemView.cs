using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A91")]
internal class RedEnvelopeItemView : MonoBehaviour
{
	[Token(Token = "0x4018E8C")]
	[FieldOffset(Offset = "0xC")]
	public UISprite m_ItemIcon;

	[Token(Token = "0x4018E8D")]
	[FieldOffset(Offset = "0x10")]
	public UIButton m_ItemBtn;

	[Token(Token = "0x4018E8E")]
	[FieldOffset(Offset = "0x14")]
	public UILabel m_ItemCount;

	[Token(Token = "0x4018E8F")]
	[FieldOffset(Offset = "0x18")]
	private LGACFNABBDC m_RedEnvelopeItem;

	[Token(Token = "0x6017357")]
	[Address(RVA = "0x1971D50", Offset = "0x1971D50", VA = "0x1971D50")]
	public RedEnvelopeItemView()
	{
	}

	[Token(Token = "0x6017358")]
	[Address(RVA = "0x1971D58", Offset = "0x1971D58", VA = "0x1971D58")]
	private void Start()
	{
	}

	[Token(Token = "0x6017359")]
	[Address(RVA = "0x1971EC0", Offset = "0x1971EC0", VA = "0x1971EC0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601735A")]
	[Address(RVA = "0x1972028", Offset = "0x1972028", VA = "0x1972028")]
	public void SetItemData(LGACFNABBDC itemInfo)
	{
	}

	[Token(Token = "0x601735B")]
	[Address(RVA = "0x1972248", Offset = "0x1972248", VA = "0x1972248")]
	public void OnRedPackageBtnClick()
	{
	}
}
