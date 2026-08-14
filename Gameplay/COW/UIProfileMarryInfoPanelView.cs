using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200392A")]
public class UIProfileMarryInfoPanelView : UIBaseView
{
	[Token(Token = "0x4017D71")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Bg;

	[Token(Token = "0x4017D72")]
	[FieldOffset(Offset = "0x18")]
	public UISprite PlayerIcon1;

	[Token(Token = "0x4017D73")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel PlayerLabel1;

	[Token(Token = "0x4017D74")]
	[FieldOffset(Offset = "0x20")]
	public UILabel PlayerLabel2;

	[Token(Token = "0x4017D75")]
	[FieldOffset(Offset = "0x24")]
	public UISprite PlayerIcon2;

	[Token(Token = "0x4017D76")]
	[FieldOffset(Offset = "0x28")]
	public UISprite MarryIcon;

	[Token(Token = "0x4017D77")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Num;

	[Token(Token = "0x4017D78")]
	[FieldOffset(Offset = "0x30")]
	public UIButton CloseButton;

	[Token(Token = "0x6016F25")]
	[Address(RVA = "0x16E9BCC", Offset = "0x16E9BCC", VA = "0x16E9BCC")]
	public UIProfileMarryInfoPanelView()
	{
	}

	[Token(Token = "0x6016F26")]
	[Address(RVA = "0x16E9BD4", Offset = "0x16E9BD4", VA = "0x16E9BD4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F27")]
	[Address(RVA = "0x16EA010", Offset = "0x16EA010", VA = "0x16EA010")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
