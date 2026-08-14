using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003480")]
public class UICommonSettingContentView : UIBaseView
{
	[Token(Token = "0x40146E9")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UICommonSettingContent;

	[Token(Token = "0x40146EA")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BG;

	[Token(Token = "0x40146EB")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Anchor;

	[Token(Token = "0x40146EC")]
	[FieldOffset(Offset = "0x20")]
	public UITable Table;

	[Token(Token = "0x40146ED")]
	[FieldOffset(Offset = "0x24")]
	public GameObject TitleContainer;

	[Token(Token = "0x40146EE")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TitleLabel;

	[Token(Token = "0x40146EF")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TiTleDesc;

	[Token(Token = "0x6016134")]
	[Address(RVA = "0x1EB4BF0", Offset = "0x1EB4BF0", VA = "0x1EB4BF0")]
	public UICommonSettingContentView()
	{
	}

	[Token(Token = "0x6016135")]
	[Address(RVA = "0x1EB4BF8", Offset = "0x1EB4BF8", VA = "0x1EB4BF8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016136")]
	[Address(RVA = "0x1EB4FC8", Offset = "0x1EB4FC8", VA = "0x1EB4FC8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
