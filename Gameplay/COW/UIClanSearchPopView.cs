using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003457")]
public class UIClanSearchPopView : UIBaseView
{
	[Token(Token = "0x4014504")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x4014505")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ClanSearchPopBtn;

	[Token(Token = "0x4014506")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget StyleSelectPopMenu;

	[Token(Token = "0x4014507")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget RegionSelectPopMenu;

	[Token(Token = "0x4014508")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Mask;

	[Token(Token = "0x60160B9")]
	[Address(RVA = "0x2B492EC", Offset = "0x2B492EC", VA = "0x2B492EC")]
	public UIClanSearchPopView()
	{
	}

	[Token(Token = "0x60160BA")]
	[Address(RVA = "0x2B492F4", Offset = "0x2B492F4", VA = "0x2B492F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160BB")]
	[Address(RVA = "0x2B49610", Offset = "0x2B49610", VA = "0x2B49610")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
