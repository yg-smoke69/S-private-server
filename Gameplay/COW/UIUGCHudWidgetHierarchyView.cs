using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A3B")]
public class UIUGCHudWidgetHierarchyView : UIBaseView
{
	[Token(Token = "0x4018965")]
	[FieldOffset(Offset = "0x14")]
	public Transform SelectedFrame;

	[Token(Token = "0x4018966")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4018967")]
	[FieldOffset(Offset = "0x1C")]
	public Transform RecycleBin;

	[Token(Token = "0x4018968")]
	[FieldOffset(Offset = "0x20")]
	public UIButton SwitchBtn;

	[Token(Token = "0x4018969")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BG;

	[Token(Token = "0x401896A")]
	[FieldOffset(Offset = "0x28")]
	public UITable Table;

	[Token(Token = "0x401896B")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite DragFrame;

	[Token(Token = "0x6017257")]
	[Address(RVA = "0x30050BC", Offset = "0x30050BC", VA = "0x30050BC")]
	public UIUGCHudWidgetHierarchyView()
	{
	}

	[Token(Token = "0x6017258")]
	[Address(RVA = "0x30050C4", Offset = "0x30050C4", VA = "0x30050C4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017259")]
	[Address(RVA = "0x3005450", Offset = "0x3005450", VA = "0x3005450")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
