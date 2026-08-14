using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038FC")]
public class UIPaymentView : UIBaseView
{
	[Token(Token = "0x4017AF8")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4017AF9")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget LeftContainer;

	[Token(Token = "0x4017AFA")]
	[FieldOffset(Offset = "0x1C")]
	public UITable LeftGrid;

	[Token(Token = "0x4017AFB")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget RightContainer;

	[Token(Token = "0x6016E9D")]
	[Address(RVA = "0x23DF4E4", Offset = "0x23DF4E4", VA = "0x23DF4E4")]
	public UIPaymentView()
	{
	}

	[Token(Token = "0x6016E9E")]
	[Address(RVA = "0x23DF4EC", Offset = "0x23DF4EC", VA = "0x23DF4EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E9F")]
	[Address(RVA = "0x23DF7B4", Offset = "0x23DF7B4", VA = "0x23DF7B4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
