using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A63")]
public class UIVeteranStandardItemMiniView : UIBaseView
{
	[Token(Token = "0x4018BDE")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ChoosedItem;

	[Token(Token = "0x4018BDF")]
	[FieldOffset(Offset = "0x18")]
	public GameObject StandardItem;

	[Token(Token = "0x60172CF")]
	[Address(RVA = "0x2CC62CC", Offset = "0x2CC62CC", VA = "0x2CC62CC")]
	public UIVeteranStandardItemMiniView()
	{
	}

	[Token(Token = "0x60172D0")]
	[Address(RVA = "0x2CC62D4", Offset = "0x2CC62D4", VA = "0x2CC62D4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172D1")]
	[Address(RVA = "0x2CC64C4", Offset = "0x2CC64C4", VA = "0x2CC64C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
