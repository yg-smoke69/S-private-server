using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003683")]
public class UIHudItemMarkBtnView : UIBaseView
{
	[Token(Token = "0x4015EC3")]
	[FieldOffset(Offset = "0x14")]
	public Transform ExtraMarkGroup;

	[Token(Token = "0x4015EC4")]
	[FieldOffset(Offset = "0x18")]
	public UIEventListener EventListener;

	[Token(Token = "0x4015EC5")]
	[FieldOffset(Offset = "0x1C")]
	public Transform BtnMark;

	[Token(Token = "0x4015EC6")]
	[FieldOffset(Offset = "0x20")]
	public UISprite CDProgress;

	[Token(Token = "0x4015EC7")]
	[FieldOffset(Offset = "0x24")]
	public GameObject CDMask;

	[Token(Token = "0x6016736")]
	[Address(RVA = "0x20A6E28", Offset = "0x20A6E28", VA = "0x20A6E28")]
	public UIHudItemMarkBtnView()
	{
	}

	[Token(Token = "0x6016737")]
	[Address(RVA = "0x20A6E30", Offset = "0x20A6E30", VA = "0x20A6E30", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016738")]
	[Address(RVA = "0x20A70FC", Offset = "0x20A70FC", VA = "0x20A70FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
