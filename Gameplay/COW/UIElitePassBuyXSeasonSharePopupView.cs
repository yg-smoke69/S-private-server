using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034FD")]
public class UIElitePassBuyXSeasonSharePopupView : UIBaseView
{
	[Token(Token = "0x4014DC6")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture BgTexture;

	[Token(Token = "0x4014DC7")]
	[FieldOffset(Offset = "0x18")]
	public UISprite ScreenshotTopBanner;

	[Token(Token = "0x4014DC8")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture HeadshotRemote;

	[Token(Token = "0x4014DC9")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HeadshotDefault;

	[Token(Token = "0x4014DCA")]
	[FieldOffset(Offset = "0x24")]
	public UIEffectSprite HeadshotLocal;

	[Token(Token = "0x4014DCB")]
	[FieldOffset(Offset = "0x28")]
	public UILabel PlayerNickname;

	[Token(Token = "0x4014DCC")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel PlayerID;

	[Token(Token = "0x4014DCD")]
	[FieldOffset(Offset = "0x30")]
	public UISprite line;

	[Token(Token = "0x4014DCE")]
	[FieldOffset(Offset = "0x34")]
	public UISprite bg;

	[Token(Token = "0x4014DCF")]
	[FieldOffset(Offset = "0x38")]
	public UILabel CurEPLabel;

	[Token(Token = "0x4014DD0")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel BuySeasonLabel;

	[Token(Token = "0x4014DD1")]
	[FieldOffset(Offset = "0x40")]
	public UIButton ShareBtn;

	[Token(Token = "0x4014DD2")]
	[FieldOffset(Offset = "0x44")]
	public Animator ShareIcon;

	[Token(Token = "0x60162A7")]
	[Address(RVA = "0x2A438F8", Offset = "0x2A438F8", VA = "0x2A438F8")]
	public UIElitePassBuyXSeasonSharePopupView()
	{
	}

	[Token(Token = "0x60162A8")]
	[Address(RVA = "0x2A43900", Offset = "0x2A43900", VA = "0x2A43900", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162A9")]
	[Address(RVA = "0x2A43F1C", Offset = "0x2A43F1C", VA = "0x2A43F1C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
