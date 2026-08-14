using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037B5")]
public class UIHUDUGC_ZombieLevelItemView : UIBaseView
{
	[Token(Token = "0x40168FE")]
	[FieldOffset(Offset = "0x14")]
	public GameObject HighLight;

	[Token(Token = "0x40168FF")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Vfx;

	[Token(Token = "0x6016ACA")]
	[Address(RVA = "0x2933168", Offset = "0x2933168", VA = "0x2933168")]
	public UIHUDUGC_ZombieLevelItemView()
	{
	}

	[Token(Token = "0x6016ACB")]
	[Address(RVA = "0x2933170", Offset = "0x2933170", VA = "0x2933170", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016ACC")]
	[Address(RVA = "0x2933360", Offset = "0x2933360", VA = "0x2933360")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
