using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038DF")]
public class UIPaymentActivityView : UIBaseView
{
	[Token(Token = "0x401798D")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIPaymentActivity;

	[Token(Token = "0x401798E")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTextureExt MainAdNetworkTexture;

	[Token(Token = "0x401798F")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton Button;

	[Token(Token = "0x4017990")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ButtonLabel;

	[Token(Token = "0x4017991")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BtnOperateBgWhite;

	[Token(Token = "0x4017992")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BtnOperateBgGray;

	[Token(Token = "0x4017993")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BtnOperateBgYellow;

	[Token(Token = "0x6016E46")]
	[Address(RVA = "0x286869C", Offset = "0x286869C", VA = "0x286869C")]
	public UIPaymentActivityView()
	{
	}

	[Token(Token = "0x6016E47")]
	[Address(RVA = "0x28686A4", Offset = "0x28686A4", VA = "0x28686A4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E48")]
	[Address(RVA = "0x2868A5C", Offset = "0x2868A5C", VA = "0x2868A5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
