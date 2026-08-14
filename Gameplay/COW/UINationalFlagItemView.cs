using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038BE")]
public class UINationalFlagItemView : UIBaseView
{
	[Token(Token = "0x40177DC")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Item;

	[Token(Token = "0x40177DD")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Flag;

	[Token(Token = "0x40177DE")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Nation;

	[Token(Token = "0x6016DE5")]
	[Address(RVA = "0x1B30624", Offset = "0x1B30624", VA = "0x1B30624")]
	public UINationalFlagItemView()
	{
	}

	[Token(Token = "0x6016DE6")]
	[Address(RVA = "0x1B3062C", Offset = "0x1B3062C", VA = "0x1B3062C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DE7")]
	[Address(RVA = "0x1B30894", Offset = "0x1B30894", VA = "0x1B30894")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
