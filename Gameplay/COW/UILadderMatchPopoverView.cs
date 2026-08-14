using Il2CppDummyDll;
using UnityEngine;
using message;
using proto;

namespace COW;

[Token(Token = "0x2002D4B")]
public class UILadderMatchPopoverView : MonoBehaviour
{
	[Token(Token = "0x40115F4")]
	[FieldOffset(Offset = "0xC")]
	public UILabel RankLabel;

	[Token(Token = "0x40115F5")]
	[FieldOffset(Offset = "0x10")]
	public UILabel TopLabel;

	[Token(Token = "0x40115F6")]
	[FieldOffset(Offset = "0x14")]
	public UILabel RankCountLabel;

	[Token(Token = "0x40115F7")]
	[FieldOffset(Offset = "0x18")]
	public UISprite GrandMasterIcon;

	[Token(Token = "0x40115F8")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RankBG;

	[Token(Token = "0x6012F54")]
	[Address(RVA = "0x22BD890", Offset = "0x22BD890", VA = "0x22BD890")]
	public UILadderMatchPopoverView()
	{
	}

	[Token(Token = "0x6012F55")]
	[Address(RVA = "0x22BD898", Offset = "0x22BD898", VA = "0x22BD898")]
	public void SetViewData(RankMasterLevel levelinfo, DGNDKMLMLPM rankMode)
	{
	}

	[Token(Token = "0x6012F56")]
	[Address(RVA = "0x22BDC48", Offset = "0x22BDC48", VA = "0x22BDC48")]
	public void HideLine()
	{
	}
}
