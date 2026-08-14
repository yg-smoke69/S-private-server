using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003490")]
public class UICreditVerifyView : UIBaseView
{
	[Token(Token = "0x40147DD")]
	[FieldOffset(Offset = "0x14")]
	public UIButton AgreeBtn;

	[Token(Token = "0x40147DE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel AgreeLabel;

	[Token(Token = "0x40147DF")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TitleLabel;

	[Token(Token = "0x40147E0")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Line1;

	[Token(Token = "0x40147E1")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Line2;

	[Token(Token = "0x40147E2")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Line3;

	[Token(Token = "0x40147E3")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton DetailBtn;

	[Token(Token = "0x40147E4")]
	[FieldOffset(Offset = "0x30")]
	public UILabel DetailLabel;

	[Token(Token = "0x40147E5")]
	[FieldOffset(Offset = "0x34")]
	public Transform Warning;

	[Token(Token = "0x6016164")]
	[Address(RVA = "0x273B034", Offset = "0x273B034", VA = "0x273B034")]
	public UICreditVerifyView()
	{
	}

	[Token(Token = "0x6016165")]
	[Address(RVA = "0x273B03C", Offset = "0x273B03C", VA = "0x273B03C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016166")]
	[Address(RVA = "0x273B4BC", Offset = "0x273B4BC", VA = "0x273B4BC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
