using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036D8")]
public class UIHudPetNameView : UIBaseView
{
	[Token(Token = "0x4016264")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x4016265")]
	[FieldOffset(Offset = "0x18")]
	public UILabel name;

	[Token(Token = "0x6016835")]
	[Address(RVA = "0x184EDF8", Offset = "0x184EDF8", VA = "0x184EDF8")]
	public UIHudPetNameView()
	{
	}

	[Token(Token = "0x6016836")]
	[Address(RVA = "0x184EE00", Offset = "0x184EE00", VA = "0x184EE00", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016837")]
	[Address(RVA = "0x184EFFC", Offset = "0x184EFFC", VA = "0x184EFFC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
