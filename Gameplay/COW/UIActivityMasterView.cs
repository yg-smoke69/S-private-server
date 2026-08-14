using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033AD")]
public class UIActivityMasterView : UIBaseView
{
	[Token(Token = "0x4013BBB")]
	[FieldOffset(Offset = "0x14")]
	public Transform TopTabContainer;

	[Token(Token = "0x4013BBC")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Content;

	[Token(Token = "0x6015EBD")]
	[Address(RVA = "0x2FB93C0", Offset = "0x2FB93C0", VA = "0x2FB93C0")]
	public UIActivityMasterView()
	{
	}

	[Token(Token = "0x6015EBE")]
	[Address(RVA = "0x2FB93C8", Offset = "0x2FB93C8", VA = "0x2FB93C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EBF")]
	[Address(RVA = "0x2FB959C", Offset = "0x2FB959C", VA = "0x2FB959C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
