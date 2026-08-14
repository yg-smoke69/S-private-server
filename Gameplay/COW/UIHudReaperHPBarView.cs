using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036FF")]
public class UIHudReaperHPBarView : UIBaseView
{
	[Token(Token = "0x401636C")]
	[FieldOffset(Offset = "0x14")]
	public UISprite HP;

	[Token(Token = "0x60168A8")]
	[Address(RVA = "0x1FDB7C8", Offset = "0x1FDB7C8", VA = "0x1FDB7C8")]
	public UIHudReaperHPBarView()
	{
	}

	[Token(Token = "0x60168A9")]
	[Address(RVA = "0x1FDB7D0", Offset = "0x1FDB7D0", VA = "0x1FDB7D0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168AA")]
	[Address(RVA = "0x1FDB978", Offset = "0x1FDB978", VA = "0x1FDB978")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
