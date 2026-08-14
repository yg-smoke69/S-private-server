using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200342B")]
public class UIChatBlockListView : UIBaseView
{
	[Token(Token = "0x40142D5")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList EasyList;

	[Token(Token = "0x40142D6")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ListCount;

	[Token(Token = "0x40142D7")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject NoMessage;

	[Token(Token = "0x6016035")]
	[Address(RVA = "0x262CC3C", Offset = "0x262CC3C", VA = "0x262CC3C")]
	public UIChatBlockListView()
	{
	}

	[Token(Token = "0x6016036")]
	[Address(RVA = "0x262CC44", Offset = "0x262CC44", VA = "0x262CC44", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016037")]
	[Address(RVA = "0x262CEA0", Offset = "0x262CEA0", VA = "0x262CEA0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
