using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003396")]
public class TipsWithItemsItemView : UIBaseView
{
	[Token(Token = "0x4013AEB")]
	[FieldOffset(Offset = "0x14")]
	public GameObject TitlePivot;

	[Token(Token = "0x4013AEC")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4013AED")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ContentPivot;

	[Token(Token = "0x4013AEE")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Content;

	[Token(Token = "0x6015E78")]
	[Address(RVA = "0x28ACFAC", Offset = "0x28ACFAC", VA = "0x28ACFAC")]
	public TipsWithItemsItemView()
	{
	}

	[Token(Token = "0x6015E79")]
	[Address(RVA = "0x28ACFB4", Offset = "0x28ACFB4", VA = "0x28ACFB4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E7A")]
	[Address(RVA = "0x28AD264", Offset = "0x28AD264", VA = "0x28AD264")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
