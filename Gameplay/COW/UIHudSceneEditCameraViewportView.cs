using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003726")]
public class UIHudSceneEditCameraViewportView : UIBaseView
{
	[Token(Token = "0x40164B3")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CamProjectionBtn;

	[Token(Token = "0x40164B4")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ResetAngleBtn;

	[Token(Token = "0x40164B5")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ProjectionIcon;

	[Token(Token = "0x40164B6")]
	[FieldOffset(Offset = "0x20")]
	public UISprite AngleIcon;

	[Token(Token = "0x601691D")]
	[Address(RVA = "0x1C55948", Offset = "0x1C55948", VA = "0x1C55948")]
	public UIHudSceneEditCameraViewportView()
	{
	}

	[Token(Token = "0x601691E")]
	[Address(RVA = "0x1C55950", Offset = "0x1C55950", VA = "0x1C55950", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601691F")]
	[Address(RVA = "0x1C55C18", Offset = "0x1C55C18", VA = "0x1C55C18")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
