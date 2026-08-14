using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003546")]
public class UIFriendRelationshipGraphItemView : UIBaseView
{
	[Token(Token = "0x4015192")]
	[FieldOffset(Offset = "0x14")]
	public UISprite FriendBG;

	[Token(Token = "0x4015193")]
	[FieldOffset(Offset = "0x18")]
	public UISprite ClosefriendBG;

	[Token(Token = "0x4015194")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ClosefriendBG2;

	[Token(Token = "0x4015195")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SelfBG;

	[Token(Token = "0x4015196")]
	[FieldOffset(Offset = "0x24")]
	public GameObject EmptyIcon;

	[Token(Token = "0x4015197")]
	[FieldOffset(Offset = "0x28")]
	public UIEffectSprite HeadSprite;

	[Token(Token = "0x4015198")]
	[FieldOffset(Offset = "0x2C")]
	public UIEffectSprite HeadSpriteEffect;

	[Token(Token = "0x4015199")]
	[FieldOffset(Offset = "0x30")]
	public UISprite FakeSprite;

	[Token(Token = "0x401519A")]
	[FieldOffset(Offset = "0x34")]
	public UINetworkTexture HeadIcon;

	[Token(Token = "0x401519B")]
	[FieldOffset(Offset = "0x38")]
	public UITexture HeadIconWidget;

	[Token(Token = "0x401519C")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton DetailInfoBtn;

	[Token(Token = "0x401519D")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget DetailInfoBtnWidget;

	[Token(Token = "0x401519E")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ExtraInfo;

	[Token(Token = "0x401519F")]
	[FieldOffset(Offset = "0x48")]
	public UILabel NickName;

	[Token(Token = "0x40151A0")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel NickNameScroll;

	[Token(Token = "0x40151A1")]
	[FieldOffset(Offset = "0x50")]
	public UIButton AddBtn;

	[Token(Token = "0x40151A2")]
	[FieldOffset(Offset = "0x54")]
	public UISprite ArrowIcon;

	[Token(Token = "0x40151A3")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ClosefriendTips;

	[Token(Token = "0x40151A4")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject SelffriendTips;

	[Token(Token = "0x40151A5")]
	[FieldOffset(Offset = "0x60")]
	public GameObject VFX_RelationShipGraphUpdate;

	[Token(Token = "0x6016382")]
	[Address(RVA = "0x250DA34", Offset = "0x250DA34", VA = "0x250DA34")]
	public UIFriendRelationshipGraphItemView()
	{
	}

	[Token(Token = "0x6016383")]
	[Address(RVA = "0x250DA3C", Offset = "0x250DA3C", VA = "0x250DA3C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016384")]
	[Address(RVA = "0x250E2C8", Offset = "0x250E2C8", VA = "0x250E2C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
