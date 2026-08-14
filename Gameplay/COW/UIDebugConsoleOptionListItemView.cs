using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034B7")]
public class UIDebugConsoleOptionListItemView : UIBaseView
{
	[Token(Token = "0x40149EB")]
	[FieldOffset(Offset = "0x14")]
	public UIButton btnOption;

	[Token(Token = "0x40149EC")]
	[FieldOffset(Offset = "0x18")]
	public UILabel OptionName;

	[Token(Token = "0x60161D9")]
	[Address(RVA = "0x2D79D68", Offset = "0x2D79D68", VA = "0x2D79D68")]
	public UIDebugConsoleOptionListItemView()
	{
	}

	[Token(Token = "0x60161DA")]
	[Address(RVA = "0x2D79D70", Offset = "0x2D79D70", VA = "0x2D79D70", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161DB")]
	[Address(RVA = "0x2D79F78", Offset = "0x2D79F78", VA = "0x2D79F78")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
