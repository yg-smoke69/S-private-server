using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037C0")]
public class UIHudVehicleBufferView : UIBaseView
{
	[Token(Token = "0x4016961")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Btn;

	[Token(Token = "0x4016962")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Icon;

	[Token(Token = "0x4016963")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Mask;

	[Token(Token = "0x4016964")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Effect;

	[Token(Token = "0x4016965")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Tips;

	[Token(Token = "0x6016AEB")]
	[Address(RVA = "0x1A6D03C", Offset = "0x1A6D03C", VA = "0x1A6D03C")]
	public UIHudVehicleBufferView()
	{
	}

	[Token(Token = "0x6016AEC")]
	[Address(RVA = "0x1A6D044", Offset = "0x1A6D044", VA = "0x1A6D044", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AED")]
	[Address(RVA = "0x1A6D360", Offset = "0x1A6D360", VA = "0x1A6D360")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
