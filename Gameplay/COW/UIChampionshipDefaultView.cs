using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200340D")]
public class UIChampionshipDefaultView : UIBaseView
{
	[Token(Token = "0x4014148")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnRule;

	[Token(Token = "0x4014149")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x6015FDB")]
	[Address(RVA = "0x2822024", Offset = "0x2822024", VA = "0x2822024")]
	public UIChampionshipDefaultView()
	{
	}

	[Token(Token = "0x6015FDC")]
	[Address(RVA = "0x282202C", Offset = "0x282202C", VA = "0x282202C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FDD")]
	[Address(RVA = "0x2822234", Offset = "0x2822234", VA = "0x2822234")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
