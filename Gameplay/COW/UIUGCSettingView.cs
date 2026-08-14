using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A48")]
public class UIUGCSettingView : UIBaseView
{
	[Token(Token = "0x4018A26")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ResetDefaultBtn;

	[Token(Token = "0x4018A27")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView SettingScrollView;

	[Token(Token = "0x4018A28")]
	[FieldOffset(Offset = "0x1C")]
	public UITable Table;

	[Token(Token = "0x4018A29")]
	[FieldOffset(Offset = "0x20")]
	public UIButton UserAgreementBtn;

	[Token(Token = "0x4018A2A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject UserAgreement;

	[Token(Token = "0x601727E")]
	[Address(RVA = "0xF4181C", Offset = "0xF4181C", VA = "0xF4181C")]
	public UIUGCSettingView()
	{
	}

	[Token(Token = "0x601727F")]
	[Address(RVA = "0xF41824", Offset = "0xF41824", VA = "0xF41824", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017280")]
	[Address(RVA = "0xF41B40", Offset = "0xF41B40", VA = "0xF41B40")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
