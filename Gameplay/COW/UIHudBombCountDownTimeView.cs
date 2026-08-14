using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035EF")]
public class UIHudBombCountDownTimeView : UIBaseView
{
	[Token(Token = "0x401597A")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelNormal;

	[Token(Token = "0x401597B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject IconNormal;

	[Token(Token = "0x401597C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelBomb;

	[Token(Token = "0x401597D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject IconBomb;

	[Token(Token = "0x401597E")]
	[FieldOffset(Offset = "0x24")]
	public GameObject VFXFlashing1;

	[Token(Token = "0x401597F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject VFXFlashing2;

	[Token(Token = "0x601657B")]
	[Address(RVA = "0x1E09710", Offset = "0x1E09710", VA = "0x1E09710")]
	public UIHudBombCountDownTimeView()
	{
	}

	[Token(Token = "0x601657C")]
	[Address(RVA = "0x1E09718", Offset = "0x1E09718", VA = "0x1E09718", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601657D")]
	[Address(RVA = "0x1E09A70", Offset = "0x1E09A70", VA = "0x1E09A70")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
