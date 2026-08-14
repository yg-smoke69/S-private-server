using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200351A")]
public class UIEPDailyTaskItemView : UIBaseView
{
	[Token(Token = "0x4014F4A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Bg;

	[Token(Token = "0x4014F4B")]
	[FieldOffset(Offset = "0x18")]
	public Transform Done;

	[Token(Token = "0x4014F4C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel DoneCnt;

	[Token(Token = "0x4014F4D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TaskDesc;

	[Token(Token = "0x4014F4E")]
	[FieldOffset(Offset = "0x24")]
	public GameObject FinishEffect;

	[Token(Token = "0x60162FE")]
	[Address(RVA = "0x2BA7E34", Offset = "0x2BA7E34", VA = "0x2BA7E34")]
	public UIEPDailyTaskItemView()
	{
	}

	[Token(Token = "0x60162FF")]
	[Address(RVA = "0x2BA7E3C", Offset = "0x2BA7E3C", VA = "0x2BA7E3C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016300")]
	[Address(RVA = "0x2BA8124", Offset = "0x2BA8124", VA = "0x2BA8124")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
