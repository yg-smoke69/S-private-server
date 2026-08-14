using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033BE")]
public class UIAnnouncementRewardItemView : UIBaseView
{
	[Token(Token = "0x4013C5A")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4013C5B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Container;

	[Token(Token = "0x4013C5C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject CheckedContainer;

	[Token(Token = "0x4013C5D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject UnCheckedContainer;

	[Token(Token = "0x4013C5E")]
	[FieldOffset(Offset = "0x24")]
	public BaseItemView2 BaseInfoView;

	[Token(Token = "0x4013C5F")]
	[FieldOffset(Offset = "0x28")]
	public UILabel IndexLabel;

	[Token(Token = "0x4013C60")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ChooseSprite;

	[Token(Token = "0x4013C61")]
	[FieldOffset(Offset = "0x30")]
	public UISprite IconSprite;

	[Token(Token = "0x6015EF0")]
	[Address(RVA = "0x1E70460", Offset = "0x1E70460", VA = "0x1E70460")]
	public UIAnnouncementRewardItemView()
	{
	}

	[Token(Token = "0x6015EF1")]
	[Address(RVA = "0x1E70468", Offset = "0x1E70468", VA = "0x1E70468", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EF2")]
	[Address(RVA = "0x1E7088C", Offset = "0x1E7088C", VA = "0x1E7088C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
