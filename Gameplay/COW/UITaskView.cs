using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039F8")]
public class UITaskView : UIBaseView
{
	[Token(Token = "0x40186E6")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BGTask;

	[Token(Token = "0x40186E7")]
	[FieldOffset(Offset = "0x18")]
	public Transform TopTabContainer;

	[Token(Token = "0x40186E8")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Content;

	[Token(Token = "0x40186E9")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget MaxRewardPreviewBorder;

	[Token(Token = "0x601718E")]
	[Address(RVA = "0x2018E34", Offset = "0x2018E34", VA = "0x2018E34")]
	public UITaskView()
	{
	}

	[Token(Token = "0x601718F")]
	[Address(RVA = "0x2018E3C", Offset = "0x2018E3C", VA = "0x2018E3C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017190")]
	[Address(RVA = "0x20190C4", Offset = "0x20190C4", VA = "0x20190C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
