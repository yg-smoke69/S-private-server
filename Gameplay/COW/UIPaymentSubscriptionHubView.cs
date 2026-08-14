using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038F4")]
public class UIPaymentSubscriptionHubView : UIBaseView
{
	[Token(Token = "0x4017AA3")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ItemsScrollView;

	[Token(Token = "0x4017AA4")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid ItemsGrid;

	[Token(Token = "0x4017AA5")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget ContentContainer;

	[Token(Token = "0x6016E85")]
	[Address(RVA = "0x29E9D54", Offset = "0x29E9D54", VA = "0x29E9D54")]
	public UIPaymentSubscriptionHubView()
	{
	}

	[Token(Token = "0x6016E86")]
	[Address(RVA = "0x29E9D5C", Offset = "0x29E9D5C", VA = "0x29E9D5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E87")]
	[Address(RVA = "0x29E9FC4", Offset = "0x29E9FC4", VA = "0x29E9FC4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
