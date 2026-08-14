using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200343C")]
public class UIChoose1From3View : UIBaseView
{
	[Token(Token = "0x40143B6")]
	[FieldOffset(Offset = "0x14")]
	public Transform Item0;

	[Token(Token = "0x40143B7")]
	[FieldOffset(Offset = "0x18")]
	public Transform Item1;

	[Token(Token = "0x40143B8")]
	[FieldOffset(Offset = "0x1C")]
	public Transform Item2;

	[Token(Token = "0x40143B9")]
	[FieldOffset(Offset = "0x20")]
	public UILabel DefaultLabelTitle;

	[Token(Token = "0x40143BA")]
	[FieldOffset(Offset = "0x24")]
	public Transform CountDown;

	[Token(Token = "0x40143BB")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SubTitle;

	[Token(Token = "0x40143BC")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel DiamondNum;

	[Token(Token = "0x40143BD")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnClaim;

	[Token(Token = "0x40143BE")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnRecharge;

	[Token(Token = "0x40143BF")]
	[FieldOffset(Offset = "0x38")]
	public UIButton Close;

	[Token(Token = "0x40143C0")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x6016068")]
	[Address(RVA = "0x208D864", Offset = "0x208D864", VA = "0x208D864")]
	public UIChoose1From3View()
	{
	}

	[Token(Token = "0x6016069")]
	[Address(RVA = "0x208D86C", Offset = "0x208D86C", VA = "0x208D86C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601606A")]
	[Address(RVA = "0x208DD34", Offset = "0x208DD34", VA = "0x208DD34")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
