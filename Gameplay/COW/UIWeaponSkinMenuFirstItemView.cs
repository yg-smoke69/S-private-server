using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A72")]
public class UIWeaponSkinMenuFirstItemView : UIBaseView
{
	[Token(Token = "0x4018CD7")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Button;

	[Token(Token = "0x4018CD8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject UnSelect;

	[Token(Token = "0x4018CD9")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel UnSelectLabel;

	[Token(Token = "0x4018CDA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject UnSelectBg;

	[Token(Token = "0x4018CDB")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Select;

	[Token(Token = "0x4018CDC")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SelectLabel;

	[Token(Token = "0x4018CDD")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SelectBg;

	[Token(Token = "0x4018CDE")]
	[FieldOffset(Offset = "0x30")]
	public GameObject TipsGO;

	[Token(Token = "0x60172FC")]
	[Address(RVA = "0x2EDE894", Offset = "0x2EDE894", VA = "0x2EDE894")]
	public UIWeaponSkinMenuFirstItemView()
	{
	}

	[Token(Token = "0x60172FD")]
	[Address(RVA = "0x2EDE89C", Offset = "0x2EDE89C", VA = "0x2EDE89C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172FE")]
	[Address(RVA = "0x2EDECB4", Offset = "0x2EDECB4", VA = "0x2EDECB4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
