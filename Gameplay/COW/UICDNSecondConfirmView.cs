using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003407")]
public class UICDNSecondConfirmView : UIBaseView
{
	[Token(Token = "0x4014123")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4014124")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ConfirmBtnLabel;

	[Token(Token = "0x4014125")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture CDNEPWebSite;

	[Token(Token = "0x4014126")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelTitle;

	[Token(Token = "0x4014127")]
	[FieldOffset(Offset = "0x24")]
	public UILabel OneTextContent;

	[Token(Token = "0x6015FC9")]
	[Address(RVA = "0x1449B58", Offset = "0x1449B58", VA = "0x1449B58")]
	public UICDNSecondConfirmView()
	{
	}

	[Token(Token = "0x6015FCA")]
	[Address(RVA = "0x1449B60", Offset = "0x1449B60", VA = "0x1449B60", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FCB")]
	[Address(RVA = "0x1449E88", Offset = "0x1449E88", VA = "0x1449E88")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
