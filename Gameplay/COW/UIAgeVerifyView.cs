using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033BC")]
public class UIAgeVerifyView : UIBaseView
{
	[Token(Token = "0x4013C43")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Skip;

	[Token(Token = "0x4013C44")]
	[FieldOffset(Offset = "0x18")]
	public GameObject NormarAgeGroup;

	[Token(Token = "0x4013C45")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton LowAge1;

	[Token(Token = "0x4013C46")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LowAge1Label;

	[Token(Token = "0x4013C47")]
	[FieldOffset(Offset = "0x24")]
	public UIButton HighAge1;

	[Token(Token = "0x4013C48")]
	[FieldOffset(Offset = "0x28")]
	public UILabel HighAge1Label;

	[Token(Token = "0x4013C49")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ChildrenAgeGroup;

	[Token(Token = "0x4013C4A")]
	[FieldOffset(Offset = "0x30")]
	public UIButton LowAge2;

	[Token(Token = "0x4013C4B")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LowAge2Label;

	[Token(Token = "0x4013C4C")]
	[FieldOffset(Offset = "0x38")]
	public UIButton MidAge2;

	[Token(Token = "0x4013C4D")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel MidAge2Label;

	[Token(Token = "0x4013C4E")]
	[FieldOffset(Offset = "0x40")]
	public UIButton HighAge2;

	[Token(Token = "0x4013C4F")]
	[FieldOffset(Offset = "0x44")]
	public UILabel HighAge2Label;

	[Token(Token = "0x6015EEA")]
	[Address(RVA = "0x1F31D64", Offset = "0x1F31D64", VA = "0x1F31D64")]
	public UIAgeVerifyView()
	{
	}

	[Token(Token = "0x6015EEB")]
	[Address(RVA = "0x1F31D6C", Offset = "0x1F31D6C", VA = "0x1F31D6C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EEC")]
	[Address(RVA = "0x1F3237C", Offset = "0x1F3237C", VA = "0x1F3237C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
