using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200348B")]
public class UICouponTipsView : UIBaseView
{
	[Token(Token = "0x401473A")]
	[FieldOffset(Offset = "0x14")]
	public Transform Content;

	[Token(Token = "0x401473B")]
	[FieldOffset(Offset = "0x18")]
	public UITable ContentTable;

	[Token(Token = "0x401473C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel CouponTitle;

	[Token(Token = "0x401473D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel CouponTips;

	[Token(Token = "0x401473E")]
	[FieldOffset(Offset = "0x24")]
	public GameObject item1;

	[Token(Token = "0x401473F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject item2;

	[Token(Token = "0x4014740")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject item3;

	[Token(Token = "0x4014741")]
	[FieldOffset(Offset = "0x30")]
	public UIButton Mask;

	[Token(Token = "0x6016155")]
	[Address(RVA = "0x1EC3B1C", Offset = "0x1EC3B1C", VA = "0x1EC3B1C")]
	public UICouponTipsView()
	{
	}

	[Token(Token = "0x6016156")]
	[Address(RVA = "0x1EC3B24", Offset = "0x1EC3B24", VA = "0x1EC3B24", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016157")]
	[Address(RVA = "0x1EC3F20", Offset = "0x1EC3F20", VA = "0x1EC3F20")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
