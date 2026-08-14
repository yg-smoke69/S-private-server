using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003937")]
public class UIPVEWeaponBtnView : UIBaseView
{
	[Token(Token = "0x4017F07")]
	[FieldOffset(Offset = "0x14")]
	public UIButton pveWeaponBtn;

	[Token(Token = "0x4017F08")]
	[FieldOffset(Offset = "0x18")]
	public UISprite weaponIcon;

	[Token(Token = "0x4017F09")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel weaponName;

	[Token(Token = "0x4017F0A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject TipsGO;

	[Token(Token = "0x4017F0B")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TagLabel;

	[Token(Token = "0x6016F4C")]
	[Address(RVA = "0x15AAC5C", Offset = "0x15AAC5C", VA = "0x15AAC5C")]
	public UIPVEWeaponBtnView()
	{
	}

	[Token(Token = "0x6016F4D")]
	[Address(RVA = "0x15AAC64", Offset = "0x15AAC64", VA = "0x15AAC64", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F4E")]
	[Address(RVA = "0x15AAF80", Offset = "0x15AAF80", VA = "0x15AAF80")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
