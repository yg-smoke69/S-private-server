using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038BF")]
public class UINationalFlagView : UIBaseView
{
	[Token(Token = "0x40177DF")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Mask;

	[Token(Token = "0x40177E0")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Close;

	[Token(Token = "0x40177E1")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList EasyList;

	[Token(Token = "0x6016DE8")]
	[Address(RVA = "0x1B3089C", Offset = "0x1B3089C", VA = "0x1B3089C")]
	public UINationalFlagView()
	{
	}

	[Token(Token = "0x6016DE9")]
	[Address(RVA = "0x1B308A4", Offset = "0x1B308A4", VA = "0x1B308A4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DEA")]
	[Address(RVA = "0x1B30B0C", Offset = "0x1B30B0C", VA = "0x1B30B0C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
