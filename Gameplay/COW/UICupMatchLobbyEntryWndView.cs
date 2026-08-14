using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003498")]
public class UICupMatchLobbyEntryWndView : UIBaseView
{
	[Token(Token = "0x4014834")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture BannerCDNTexture;

	[Token(Token = "0x4014835")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture CupCDNTexture;

	[Token(Token = "0x4014836")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnCupMatch;

	[Token(Token = "0x4014837")]
	[FieldOffset(Offset = "0x20")]
	public UILabel BtnCupMatchLabel;

	[Token(Token = "0x4014838")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelStatus;

	[Token(Token = "0x4014839")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelCupMatch;

	[Token(Token = "0x401483A")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LabelInfo;

	[Token(Token = "0x601617C")]
	[Address(RVA = "0x2AA6070", Offset = "0x2AA6070", VA = "0x2AA6070")]
	public UICupMatchLobbyEntryWndView()
	{
	}

	[Token(Token = "0x601617D")]
	[Address(RVA = "0x2AA6078", Offset = "0x2AA6078", VA = "0x2AA6078", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601617E")]
	[Address(RVA = "0x2AA6460", Offset = "0x2AA6460", VA = "0x2AA6460")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
