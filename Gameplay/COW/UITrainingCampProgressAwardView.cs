using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A0B")]
public class UITrainingCampProgressAwardView : UIBaseView
{
	[Token(Token = "0x40187C3")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Node;

	[Token(Token = "0x40187C4")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Milestone;

	[Token(Token = "0x40187C5")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject VerticalPos;

	[Token(Token = "0x40187C6")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HorizontalPos;

	[Token(Token = "0x40187C7")]
	[FieldOffset(Offset = "0x24")]
	public UIButton AwardBtn;

	[Token(Token = "0x40187C8")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Received;

	[Token(Token = "0x40187C9")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Finished;

	[Token(Token = "0x40187CA")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Hintbg;

	[Token(Token = "0x40187CB")]
	[FieldOffset(Offset = "0x34")]
	public UILabel HintLabel;

	[Token(Token = "0x40187CC")]
	[FieldOffset(Offset = "0x38")]
	public UISprite Claimed;

	[Token(Token = "0x60171C7")]
	[Address(RVA = "0x1C1F3BC", Offset = "0x1C1F3BC", VA = "0x1C1F3BC")]
	public UITrainingCampProgressAwardView()
	{
	}

	[Token(Token = "0x60171C8")]
	[Address(RVA = "0x1C1F3C4", Offset = "0x1C1F3C4", VA = "0x1C1F3C4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171C9")]
	[Address(RVA = "0x1C1F8A8", Offset = "0x1C1F8A8", VA = "0x1C1F8A8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
