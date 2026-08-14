using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200373A")]
public class UIHudSceneEditPutView : UIBaseView
{
	[Token(Token = "0x4016528")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnCancel;

	[Token(Token = "0x4016529")]
	[FieldOffset(Offset = "0x18")]
	public UIEventListener BtnRotate;

	[Token(Token = "0x401652A")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnPut;

	[Token(Token = "0x401652B")]
	[FieldOffset(Offset = "0x20")]
	public UISprite btnPutIcon;

	[Token(Token = "0x6016959")]
	[Address(RVA = "0x24EE0A4", Offset = "0x24EE0A4", VA = "0x24EE0A4")]
	public UIHudSceneEditPutView()
	{
	}

	[Token(Token = "0x601695A")]
	[Address(RVA = "0x24EE0AC", Offset = "0x24EE0AC", VA = "0x24EE0AC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601695B")]
	[Address(RVA = "0x24EE374", Offset = "0x24EE374", VA = "0x24EE374")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
