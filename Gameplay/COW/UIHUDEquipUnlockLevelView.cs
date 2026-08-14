using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003646")]
public class UIHUDEquipUnlockLevelView : UIBaseView
{
	[Token(Token = "0x4015C54")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid LevelGrid;

	[Token(Token = "0x4015C55")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CountdownLabel;

	[Token(Token = "0x4015C56")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x601667F")]
	[Address(RVA = "0x1679B50", Offset = "0x1679B50", VA = "0x1679B50")]
	public UIHUDEquipUnlockLevelView()
	{
	}

	[Token(Token = "0x6016680")]
	[Address(RVA = "0x1679B58", Offset = "0x1679B58", VA = "0x1679B58", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016681")]
	[Address(RVA = "0x1679DC0", Offset = "0x1679DC0", VA = "0x1679DC0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
