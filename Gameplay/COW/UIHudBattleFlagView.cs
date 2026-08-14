using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035E5")]
public class UIHudBattleFlagView : UIBaseView
{
	[Token(Token = "0x401592E")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnBattleFlag;

	[Token(Token = "0x601655D")]
	[Address(RVA = "0x1DFA778", Offset = "0x1DFA778", VA = "0x1DFA778")]
	public UIHudBattleFlagView()
	{
	}

	[Token(Token = "0x601655E")]
	[Address(RVA = "0x1DFA780", Offset = "0x1DFA780", VA = "0x1DFA780", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601655F")]
	[Address(RVA = "0x1DFA928", Offset = "0x1DFA928", VA = "0x1DFA928")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
