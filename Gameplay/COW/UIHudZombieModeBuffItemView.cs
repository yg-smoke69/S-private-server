using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037EC")]
public class UIHudZombieModeBuffItemView : UIBaseView
{
	[Token(Token = "0x4016AE8")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Desc;

	[Token(Token = "0x4016AE9")]
	[FieldOffset(Offset = "0x18")]
	public UIButton UIHudZombieModeBuffItem;

	[Token(Token = "0x6016B6F")]
	[Address(RVA = "0x2945C48", Offset = "0x2945C48", VA = "0x2945C48")]
	public UIHudZombieModeBuffItemView()
	{
	}

	[Token(Token = "0x6016B70")]
	[Address(RVA = "0x2945C50", Offset = "0x2945C50", VA = "0x2945C50", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B71")]
	[Address(RVA = "0x2945E58", Offset = "0x2945E58", VA = "0x2945E58")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
