using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039EA")]
public class UIStandardCDNTabItemView : UIBaseView
{
	[Token(Token = "0x4018612")]
	[FieldOffset(Offset = "0x14")]
	public Animation Anim;

	[Token(Token = "0x4018613")]
	[FieldOffset(Offset = "0x18")]
	public UISprite DownArrow;

	[Token(Token = "0x4018614")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite UpArrow;

	[Token(Token = "0x4018615")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Select;

	[Token(Token = "0x4018616")]
	[FieldOffset(Offset = "0x24")]
	public UILabel SelectLabel;

	[Token(Token = "0x4018617")]
	[FieldOffset(Offset = "0x28")]
	public GameObject UnFolded;

	[Token(Token = "0x4018618")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel UnFoldedLabel;

	[Token(Token = "0x4018619")]
	[FieldOffset(Offset = "0x30")]
	public GameObject UnSelect;

	[Token(Token = "0x401861A")]
	[FieldOffset(Offset = "0x34")]
	public UISprite UnSelectWidget;

	[Token(Token = "0x401861B")]
	[FieldOffset(Offset = "0x38")]
	public UILabel UnSelectLabel;

	[Token(Token = "0x401861C")]
	[FieldOffset(Offset = "0x3C")]
	public UITipsButton RedPoint;

	[Token(Token = "0x401861D")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Tag;

	[Token(Token = "0x401861E")]
	[FieldOffset(Offset = "0x44")]
	public UILabel TagLabel;

	[Token(Token = "0x401861F")]
	[FieldOffset(Offset = "0x48")]
	public UISprite TagIconBg;

	[Token(Token = "0x4018620")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite TagIcon;

	[Token(Token = "0x4018621")]
	[FieldOffset(Offset = "0x50")]
	public UIButton Button;

	[Token(Token = "0x4018622")]
	[FieldOffset(Offset = "0x54")]
	public GameObject DrawerFixRect;

	[Token(Token = "0x4018623")]
	[FieldOffset(Offset = "0x58")]
	public GameObject SelectedLockIcon;

	[Token(Token = "0x4018624")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject UnSelectedLockIcon;

	[Token(Token = "0x4018625")]
	[FieldOffset(Offset = "0x60")]
	public UITipsButton ClaimedTag;

	[Token(Token = "0x6017164")]
	[Address(RVA = "0x20642F0", Offset = "0x20642F0", VA = "0x20642F0")]
	public UIStandardCDNTabItemView()
	{
	}

	[Token(Token = "0x6017165")]
	[Address(RVA = "0x20642F8", Offset = "0x20642F8", VA = "0x20642F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017166")]
	[Address(RVA = "0x2064B6C", Offset = "0x2064B6C", VA = "0x2064B6C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
