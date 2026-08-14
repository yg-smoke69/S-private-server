using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033FE")]
public class UIBigEventLobbyEnterWndView : UIBaseView
{
	[Token(Token = "0x4014053")]
	[FieldOffset(Offset = "0x14")]
	public GameObject OpenEffect;

	[Token(Token = "0x4014054")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture CDNTitle;

	[Token(Token = "0x4014055")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton CloseBtn;

	[Token(Token = "0x4014056")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList Grid;

	[Token(Token = "0x4014057")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Title;

	[Token(Token = "0x4014058")]
	[FieldOffset(Offset = "0x28")]
	public UICountDownLabel GachaCountDownLabel;

	[Token(Token = "0x4014059")]
	[FieldOffset(Offset = "0x2C")]
	public UINetworkTexture CDNBg;

	[Token(Token = "0x6015FAE")]
	[Address(RVA = "0x300EA00", Offset = "0x300EA00", VA = "0x300EA00")]
	public UIBigEventLobbyEnterWndView()
	{
	}

	[Token(Token = "0x6015FAF")]
	[Address(RVA = "0x300EA08", Offset = "0x300EA08", VA = "0x300EA08", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FB0")]
	[Address(RVA = "0x300EDE4", Offset = "0x300EDE4", VA = "0x300EDE4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
