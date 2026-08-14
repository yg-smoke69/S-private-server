using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033A2")]
public class UIActivityCollectionSigninItemView : UIBaseView
{
	[Token(Token = "0x4013B58")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x4013B59")]
	[FieldOffset(Offset = "0x18")]
	public UILabel DateText;

	[Token(Token = "0x4013B5A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Item;

	[Token(Token = "0x4013B5B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Locked;

	[Token(Token = "0x4013B5C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject LockIcon;

	[Token(Token = "0x4013B5D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject UnCheckedContainer;

	[Token(Token = "0x4013B5E")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject CheckedContainer;

	[Token(Token = "0x4013B5F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Glow;

	[Token(Token = "0x4013B60")]
	[FieldOffset(Offset = "0x34")]
	public UIButton ClaimButton;

	[Token(Token = "0x4013B61")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Claimed;

	[Token(Token = "0x4013B62")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ClaimedIcon;

	[Token(Token = "0x6015E9C")]
	[Address(RVA = "0x2A0CAA8", Offset = "0x2A0CAA8", VA = "0x2A0CAA8")]
	public UIActivityCollectionSigninItemView()
	{
	}

	[Token(Token = "0x6015E9D")]
	[Address(RVA = "0x2A0CAB0", Offset = "0x2A0CAB0", VA = "0x2A0CAB0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E9E")]
	[Address(RVA = "0x2A0CFAC", Offset = "0x2A0CFAC", VA = "0x2A0CFAC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
