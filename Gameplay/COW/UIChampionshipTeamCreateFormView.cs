using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200341C")]
public class UIChampionshipTeamCreateFormView : UIBaseView
{
	[Token(Token = "0x40141F3")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Confirm;

	[Token(Token = "0x40141F4")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Cancel;

	[Token(Token = "0x40141F5")]
	[FieldOffset(Offset = "0x1C")]
	public UITable Content;

	[Token(Token = "0x40141F6")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Name;

	[Token(Token = "0x40141F7")]
	[FieldOffset(Offset = "0x24")]
	public UIInput NameInput;

	[Token(Token = "0x40141F8")]
	[FieldOffset(Offset = "0x28")]
	public UIInput ChannelNameValue;

	[Token(Token = "0x40141F9")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Channel;

	[Token(Token = "0x40141FA")]
	[FieldOffset(Offset = "0x30")]
	public UIButton ChannelSelect;

	[Token(Token = "0x40141FB")]
	[FieldOffset(Offset = "0x34")]
	public GameObject NationalFlag;

	[Token(Token = "0x40141FC")]
	[FieldOffset(Offset = "0x38")]
	public UISprite Flag;

	[Token(Token = "0x40141FD")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton FlagSelect;

	[Token(Token = "0x40141FE")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ClanAvatar;

	[Token(Token = "0x40141FF")]
	[FieldOffset(Offset = "0x44")]
	public UIEffectSprite Avatar;

	[Token(Token = "0x4014200")]
	[FieldOffset(Offset = "0x48")]
	public UIButton AvatarSelect;

	[Token(Token = "0x4014201")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject ClanBanner;

	[Token(Token = "0x4014202")]
	[FieldOffset(Offset = "0x50")]
	public UIEffectSprite Banner;

	[Token(Token = "0x4014203")]
	[FieldOffset(Offset = "0x54")]
	public UISprite MiniBanner;

	[Token(Token = "0x4014204")]
	[FieldOffset(Offset = "0x58")]
	public UIButton BannerSelect;

	[Token(Token = "0x6016008")]
	[Address(RVA = "0x283E370", Offset = "0x283E370", VA = "0x283E370")]
	public UIChampionshipTeamCreateFormView()
	{
	}

	[Token(Token = "0x6016009")]
	[Address(RVA = "0x283E378", Offset = "0x283E378", VA = "0x283E378", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601600A")]
	[Address(RVA = "0x283EB5C", Offset = "0x283EB5C", VA = "0x283EB5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
