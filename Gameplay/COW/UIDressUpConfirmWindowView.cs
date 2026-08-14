using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034F7")]
public class UIDressUpConfirmWindowView : UIBaseView
{
	[Token(Token = "0x4014D5E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Style1;

	[Token(Token = "0x4014D5F")]
	[FieldOffset(Offset = "0x18")]
	public UIButton CancelBtn1;

	[Token(Token = "0x4014D60")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ConfirmBtn1;

	[Token(Token = "0x4014D61")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TipsLabel1;

	[Token(Token = "0x4014D62")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Style2;

	[Token(Token = "0x4014D63")]
	[FieldOffset(Offset = "0x28")]
	public UIButton ConfirmBtn2;

	[Token(Token = "0x4014D64")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TipsLabel2;

	[Token(Token = "0x4014D65")]
	[FieldOffset(Offset = "0x30")]
	public UIButton CancelBtn2;

	[Token(Token = "0x6016295")]
	[Address(RVA = "0x276A928", Offset = "0x276A928", VA = "0x276A928")]
	public UIDressUpConfirmWindowView()
	{
	}

	[Token(Token = "0x6016296")]
	[Address(RVA = "0x276A930", Offset = "0x276A930", VA = "0x276A930", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016297")]
	[Address(RVA = "0x276AD60", Offset = "0x276AD60", VA = "0x276AD60")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
