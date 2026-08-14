using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200387C")]
public class UIManualGrownItemGroupView : UIBaseView
{
	[Token(Token = "0x4017433")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Pos0;

	[Token(Token = "0x4017434")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Pos2;

	[Token(Token = "0x4017435")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Pos1;

	[Token(Token = "0x4017436")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Arrow;

	[Token(Token = "0x4017437")]
	[FieldOffset(Offset = "0x24")]
	public GameObject LvDisableState;

	[Token(Token = "0x4017438")]
	[FieldOffset(Offset = "0x28")]
	public UILabel DisableLabel;

	[Token(Token = "0x4017439")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LvEnableState;

	[Token(Token = "0x401743A")]
	[FieldOffset(Offset = "0x30")]
	public UILabel EnableLable;

	[Token(Token = "0x401743B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Lv1View;

	[Token(Token = "0x6016D1F")]
	[Address(RVA = "0x2C276DC", Offset = "0x2C276DC", VA = "0x2C276DC")]
	public UIManualGrownItemGroupView()
	{
	}

	[Token(Token = "0x6016D20")]
	[Address(RVA = "0x2C276E4", Offset = "0x2C276E4", VA = "0x2C276E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D21")]
	[Address(RVA = "0x2C27B38", Offset = "0x2C27B38", VA = "0x2C27B38")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
