using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003461")]
public class UIClanWarMarchTeamReadyWndView : UIBaseView
{
	[Token(Token = "0x4014572")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTextureExt CDNTexture;

	[Token(Token = "0x4014573")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid Grid;

	[Token(Token = "0x4014574")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ReadyNum;

	[Token(Token = "0x4014575")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TotalNum;

	[Token(Token = "0x4014576")]
	[FieldOffset(Offset = "0x24")]
	public GameObject PreparedContainer;

	[Token(Token = "0x4014577")]
	[FieldOffset(Offset = "0x28")]
	public UICountDownLabel WaitingCountDown;

	[Token(Token = "0x4014578")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NotPreparedContainer;

	[Token(Token = "0x4014579")]
	[FieldOffset(Offset = "0x30")]
	public UIButton AcceptBtn;

	[Token(Token = "0x401457A")]
	[FieldOffset(Offset = "0x34")]
	public UIButton DeclineBtn;

	[Token(Token = "0x401457B")]
	[FieldOffset(Offset = "0x38")]
	public UICountDownLabel AutoDeclineCountDown;

	[Token(Token = "0x60160D7")]
	[Address(RVA = "0x28FEFC4", Offset = "0x28FEFC4", VA = "0x28FEFC4")]
	public UIClanWarMarchTeamReadyWndView()
	{
	}

	[Token(Token = "0x60160D8")]
	[Address(RVA = "0x28FEFCC", Offset = "0x28FEFCC", VA = "0x28FEFCC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160D9")]
	[Address(RVA = "0x28FF4BC", Offset = "0x28FF4BC", VA = "0x28FF4BC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
