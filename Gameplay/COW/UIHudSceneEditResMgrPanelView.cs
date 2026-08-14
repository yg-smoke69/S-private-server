using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200373B")]
public class UIHudSceneEditResMgrPanelView : UIBaseView
{
	[Token(Token = "0x401652C")]
	[FieldOffset(Offset = "0x14")]
	public Transform SceneObjTypeFliterMenu;

	[Token(Token = "0x401652D")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList ObjGrid;

	[Token(Token = "0x401652E")]
	[FieldOffset(Offset = "0x1C")]
	public Transform SceneObjScriptEditFliterMenu;

	[Token(Token = "0x401652F")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ToggleBtn;

	[Token(Token = "0x4016530")]
	[FieldOffset(Offset = "0x24")]
	public UIButton ToggleBtnReverse;

	[Token(Token = "0x4016531")]
	[FieldOffset(Offset = "0x28")]
	public TweenPosition TweenPos;

	[Token(Token = "0x601695C")]
	[Address(RVA = "0x24F1848", Offset = "0x24F1848", VA = "0x24F1848")]
	public UIHudSceneEditResMgrPanelView()
	{
	}

	[Token(Token = "0x601695D")]
	[Address(RVA = "0x24F1850", Offset = "0x24F1850", VA = "0x24F1850", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601695E")]
	[Address(RVA = "0x24F1B88", Offset = "0x24F1B88", VA = "0x24F1B88")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
