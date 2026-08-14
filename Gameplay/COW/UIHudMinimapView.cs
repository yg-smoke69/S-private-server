using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036B4")]
public class UIHudMinimapView : UIBaseView
{
	[Token(Token = "0x40160BC")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition TweenPosition;

	[Token(Token = "0x40160BD")]
	[FieldOffset(Offset = "0x18")]
	public Transform RootContainer;

	[Token(Token = "0x40160BE")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject MapQuad;

	[Token(Token = "0x40160BF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ForecastEffect;

	[Token(Token = "0x40160C0")]
	[FieldOffset(Offset = "0x24")]
	public UISprite FactionIcon;

	[Token(Token = "0x40160C1")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NoSignal;

	[Token(Token = "0x40160C2")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NoSignalGo;

	[Token(Token = "0x40160C3")]
	[FieldOffset(Offset = "0x30")]
	public GameObject MapContent;

	[Token(Token = "0x40160C4")]
	[FieldOffset(Offset = "0x34")]
	public UIPanel SafeZonePanel;

	[Token(Token = "0x40160C5")]
	[FieldOffset(Offset = "0x38")]
	public UISprite MapFrame;

	[Token(Token = "0x40160C6")]
	[FieldOffset(Offset = "0x3C")]
	public Transform MapRot;

	[Token(Token = "0x40160C7")]
	[FieldOffset(Offset = "0x40")]
	public Transform MapContainer;

	[Token(Token = "0x40160C8")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Enemy;

	[Token(Token = "0x40160C9")]
	[FieldOffset(Offset = "0x48")]
	public GameObject PlayerArrow;

	[Token(Token = "0x40160CA")]
	[FieldOffset(Offset = "0x4C")]
	public TweenAlpha UavPlayerArrow;

	[Token(Token = "0x40160CB")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Arrow;

	[Token(Token = "0x40160CC")]
	[FieldOffset(Offset = "0x54")]
	public GameObject SoundTips;

	[Token(Token = "0x40160CD")]
	[FieldOffset(Offset = "0x58")]
	public Transform SoundTipsContainer;

	[Token(Token = "0x40160CE")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject SpectatorCamera;

	[Token(Token = "0x40160CF")]
	[FieldOffset(Offset = "0x60")]
	public GameObject csEnemyBornPos;

	[Token(Token = "0x40160D0")]
	[FieldOffset(Offset = "0x64")]
	public UIButton BtnZoom;

	[Token(Token = "0x40160D1")]
	[FieldOffset(Offset = "0x68")]
	public GameObject Effect_Arrow;

	[Token(Token = "0x40160D2")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject BottomGo;

	[Token(Token = "0x40160D3")]
	[FieldOffset(Offset = "0x70")]
	public GameObject PartyGame;

	[Token(Token = "0x40160D4")]
	[FieldOffset(Offset = "0x74")]
	public UISprite PartyGameIcon;

	[Token(Token = "0x40160D5")]
	[FieldOffset(Offset = "0x78")]
	public UISprite PlayerArrowShadow;

	[Token(Token = "0x60167C9")]
	[Address(RVA = "0x19CB258", Offset = "0x19CB258", VA = "0x19CB258")]
	public UIHudMinimapView()
	{
	}

	[Token(Token = "0x60167CA")]
	[Address(RVA = "0x19CB260", Offset = "0x19CB260", VA = "0x19CB260", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167CB")]
	[Address(RVA = "0x19CBC20", Offset = "0x19CBC20", VA = "0x19CBC20")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
