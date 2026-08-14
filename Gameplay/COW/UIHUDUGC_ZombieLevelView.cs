using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037B6")]
public class UIHUDUGC_ZombieLevelView : UIBaseView
{
	[Token(Token = "0x4016900")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid Root;

	[Token(Token = "0x4016901")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget RootWidget;

	[Token(Token = "0x4016902")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Tips;

	[Token(Token = "0x4016903")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TipsInfo;

	[Token(Token = "0x4016904")]
	[FieldOffset(Offset = "0x24")]
	public UICustomHoverButton TipsButton;

	[Token(Token = "0x6016ACD")]
	[Address(RVA = "0x2933368", Offset = "0x2933368", VA = "0x2933368")]
	public UIHUDUGC_ZombieLevelView()
	{
	}

	[Token(Token = "0x6016ACE")]
	[Address(RVA = "0x2933370", Offset = "0x2933370", VA = "0x2933370", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016ACF")]
	[Address(RVA = "0x293368C", Offset = "0x293368C", VA = "0x293368C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
