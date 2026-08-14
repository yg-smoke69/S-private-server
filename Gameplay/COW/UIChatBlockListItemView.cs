using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200342A")]
public class UIChatBlockListItemView : UIBaseView
{
	[Token(Token = "0x40142D2")]
	[FieldOffset(Offset = "0x14")]
	public UILabel PlayerName;

	[Token(Token = "0x40142D3")]
	[FieldOffset(Offset = "0x18")]
	public UILabel PlayerID;

	[Token(Token = "0x40142D4")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton RemoveBlock;

	[Token(Token = "0x6016032")]
	[Address(RVA = "0x262C9C4", Offset = "0x262C9C4", VA = "0x262C9C4")]
	public UIChatBlockListItemView()
	{
	}

	[Token(Token = "0x6016033")]
	[Address(RVA = "0x262C9CC", Offset = "0x262C9CC", VA = "0x262C9CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016034")]
	[Address(RVA = "0x262CC34", Offset = "0x262CC34", VA = "0x262CC34")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
