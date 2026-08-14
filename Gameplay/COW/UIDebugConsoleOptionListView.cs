using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034B8")]
public class UIDebugConsoleOptionListView : UIBaseView
{
	[Token(Token = "0x40149ED")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Board;

	[Token(Token = "0x40149EE")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList EasyList;

	[Token(Token = "0x60161DC")]
	[Address(RVA = "0x2D79F80", Offset = "0x2D79F80", VA = "0x2D79F80")]
	public UIDebugConsoleOptionListView()
	{
	}

	[Token(Token = "0x60161DD")]
	[Address(RVA = "0x2D79F88", Offset = "0x2D79F88", VA = "0x2D79F88", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161DE")]
	[Address(RVA = "0x2D7A190", Offset = "0x2D7A190", VA = "0x2D7A190")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
