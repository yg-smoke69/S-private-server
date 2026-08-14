using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033FB")]
public class UIBigEventFriendReunionTitleView : UIBaseView
{
	[Token(Token = "0x4014033")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIBigEventFriendReunionTitle;

	[Token(Token = "0x4014034")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4014035")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton DetailButton;

	[Token(Token = "0x4014036")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SelfLink;

	[Token(Token = "0x4014037")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Label;

	[Token(Token = "0x4014038")]
	[FieldOffset(Offset = "0x28")]
	public UIButton LinkButton;

	[Token(Token = "0x4014039")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton CallbackButton;

	[Token(Token = "0x401403A")]
	[FieldOffset(Offset = "0x30")]
	public UILabel BtnOperateLabelWhite;

	[Token(Token = "0x401403B")]
	[FieldOffset(Offset = "0x34")]
	public UISprite ReunionInviterItemBg;

	[Token(Token = "0x6015FA5")]
	[Address(RVA = "0x300B184", Offset = "0x300B184", VA = "0x300B184")]
	public UIBigEventFriendReunionTitleView()
	{
	}

	[Token(Token = "0x6015FA6")]
	[Address(RVA = "0x300B18C", Offset = "0x300B18C", VA = "0x300B18C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FA7")]
	[Address(RVA = "0x300B628", Offset = "0x300B628", VA = "0x300B628")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
