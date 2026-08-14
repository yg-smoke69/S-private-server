using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200371D")]
public class UIHUDRushingPetsMatchResultView : UIBaseView
{
	[Token(Token = "0x4016450")]
	[FieldOffset(Offset = "0x14")]
	public UIRushingPetsMatchResultItem ResultItemTemplate;

	[Token(Token = "0x4016451")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid ItemGrid;

	[Token(Token = "0x6016902")]
	[Address(RVA = "0x220E890", Offset = "0x220E890", VA = "0x220E890")]
	public UIHUDRushingPetsMatchResultView()
	{
	}

	[Token(Token = "0x6016903")]
	[Address(RVA = "0x220E898", Offset = "0x220E898", VA = "0x220E898", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016904")]
	[Address(RVA = "0x220EA00", Offset = "0x220EA00", VA = "0x220EA00")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
