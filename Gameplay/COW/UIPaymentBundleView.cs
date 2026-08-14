using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038E5")]
public class UIPaymentBundleView : UIBaseView
{
	[Token(Token = "0x40179E4")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Top;

	[Token(Token = "0x40179E5")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView BundleTitleScrollView;

	[Token(Token = "0x40179E6")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid BundleTitleGrid;

	[Token(Token = "0x40179E7")]
	[FieldOffset(Offset = "0x20")]
	public Transform Middle;

	[Token(Token = "0x40179E8")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ListRoot;

	[Token(Token = "0x40179E9")]
	[FieldOffset(Offset = "0x28")]
	public UIScrollView BundlesScrollView;

	[Token(Token = "0x40179EA")]
	[FieldOffset(Offset = "0x2C")]
	public UIEasyList BundlesList;

	[Token(Token = "0x40179EB")]
	[FieldOffset(Offset = "0x30")]
	public GameObject TableRoot;

	[Token(Token = "0x40179EC")]
	[FieldOffset(Offset = "0x34")]
	public UIScrollView BundlesTableScrollView;

	[Token(Token = "0x40179ED")]
	[FieldOffset(Offset = "0x38")]
	public UITable TableContent;

	[Token(Token = "0x40179EE")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject EmptyHint;

	[Token(Token = "0x6016E58")]
	[Address(RVA = "0x2878E68", Offset = "0x2878E68", VA = "0x2878E68")]
	public UIPaymentBundleView()
	{
	}

	[Token(Token = "0x6016E59")]
	[Address(RVA = "0x2878E70", Offset = "0x2878E70", VA = "0x2878E70", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E5A")]
	[Address(RVA = "0x2879380", Offset = "0x2879380", VA = "0x2879380")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
