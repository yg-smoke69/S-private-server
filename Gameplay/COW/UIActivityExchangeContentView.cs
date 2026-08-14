using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033A4")]
public class UIActivityExchangeContentView : UIBaseView
{
	[Token(Token = "0x4013B6A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ScrollView_NoTabs;

	[Token(Token = "0x4013B6B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ScrollView;

	[Token(Token = "0x4013B6C")]
	[FieldOffset(Offset = "0x1C")]
	public UITable ContentTable;

	[Token(Token = "0x4013B6D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Introduction;

	[Token(Token = "0x4013B6E")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Time;

	[Token(Token = "0x4013B6F")]
	[FieldOffset(Offset = "0x28")]
	public UIDragScrollView DragArea;

	[Token(Token = "0x4013B70")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget DragWidget;

	[Token(Token = "0x6015EA2")]
	[Address(RVA = "0x2FA610C", Offset = "0x2FA610C", VA = "0x2FA610C")]
	public UIActivityExchangeContentView()
	{
	}

	[Token(Token = "0x6015EA3")]
	[Address(RVA = "0x2FA6114", Offset = "0x2FA6114", VA = "0x2FA6114", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EA4")]
	[Address(RVA = "0x2FA64E4", Offset = "0x2FA64E4", VA = "0x2FA64E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
