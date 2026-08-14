using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034A3")]
public class UICupMatchTeamCreateFormView : UIBaseView
{
	[Token(Token = "0x40148B7")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Confirm;

	[Token(Token = "0x40148B8")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Cancel;

	[Token(Token = "0x40148B9")]
	[FieldOffset(Offset = "0x1C")]
	public UITable Content;

	[Token(Token = "0x40148BA")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Name;

	[Token(Token = "0x40148BB")]
	[FieldOffset(Offset = "0x24")]
	public UIInput NameInput;

	[Token(Token = "0x40148BC")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NationalFlag;

	[Token(Token = "0x40148BD")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Flag;

	[Token(Token = "0x40148BE")]
	[FieldOffset(Offset = "0x30")]
	public UIButton FlagSelect;

	[Token(Token = "0x40148BF")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ClanAvatar;

	[Token(Token = "0x40148C0")]
	[FieldOffset(Offset = "0x38")]
	public UIEffectSprite Avatar;

	[Token(Token = "0x40148C1")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton AvatarSelect;

	[Token(Token = "0x40148C2")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ClanBanner;

	[Token(Token = "0x40148C3")]
	[FieldOffset(Offset = "0x44")]
	public UIEffectSprite Banner;

	[Token(Token = "0x40148C4")]
	[FieldOffset(Offset = "0x48")]
	public UISprite MiniBanner;

	[Token(Token = "0x40148C5")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BannerSelect;

	[Token(Token = "0x601619D")]
	[Address(RVA = "0x2AB9DD8", Offset = "0x2AB9DD8", VA = "0x2AB9DD8")]
	public UICupMatchTeamCreateFormView()
	{
	}

	[Token(Token = "0x601619E")]
	[Address(RVA = "0x2AB9DE0", Offset = "0x2AB9DE0", VA = "0x2AB9DE0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601619F")]
	[Address(RVA = "0x2ABA4A4", Offset = "0x2ABA4A4", VA = "0x2ABA4A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
