using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200377C")]
public class UIHudTrainingGameQueueInfoView : UIBaseView
{
	[Token(Token = "0x40167A9")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Total;

	[Token(Token = "0x40167AA")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Idx;

	[Token(Token = "0x40167AB")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel s;

	[Token(Token = "0x6016A1F")]
	[Address(RVA = "0x1584C28", Offset = "0x1584C28", VA = "0x1584C28")]
	public UIHudTrainingGameQueueInfoView()
	{
	}

	[Token(Token = "0x6016A20")]
	[Address(RVA = "0x1584C30", Offset = "0x1584C30", VA = "0x1584C30", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A21")]
	[Address(RVA = "0x1584E98", Offset = "0x1584E98", VA = "0x1584E98")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
