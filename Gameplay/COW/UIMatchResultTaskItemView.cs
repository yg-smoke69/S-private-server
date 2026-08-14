using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200389B")]
public class UIMatchResultTaskItemView : UIBaseView
{
	[Token(Token = "0x4017660")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Desc;

	[Token(Token = "0x4017661")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ProcessLabel;

	[Token(Token = "0x4017662")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Gained;

	[Token(Token = "0x4017663")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Anim;

	[Token(Token = "0x4017664")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GainedIcon;

	[Token(Token = "0x6016D7C")]
	[Address(RVA = "0x268BA80", Offset = "0x268BA80", VA = "0x268BA80")]
	public UIMatchResultTaskItemView()
	{
	}

	[Token(Token = "0x6016D7D")]
	[Address(RVA = "0x268BA88", Offset = "0x268BA88", VA = "0x268BA88", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D7E")]
	[Address(RVA = "0x268BD8C", Offset = "0x268BD8C", VA = "0x268BD8C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
