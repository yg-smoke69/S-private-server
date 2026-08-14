using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003595")]
public class UIGachaPreviewView : UIBaseView
{
	[Token(Token = "0x401555E")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView GachaPreviewScrollView;

	[Token(Token = "0x401555F")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList Grid;

	[Token(Token = "0x4015560")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BGClickLottery;

	[Token(Token = "0x4015561")]
	[FieldOffset(Offset = "0x20")]
	public UIButton btnclose;

	[Token(Token = "0x4015562")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnProbability;

	[Token(Token = "0x601646F")]
	[Address(RVA = "0x2A26C94", Offset = "0x2A26C94", VA = "0x2A26C94")]
	public UIGachaPreviewView()
	{
	}

	[Token(Token = "0x6016470")]
	[Address(RVA = "0x2A26C9C", Offset = "0x2A26C9C", VA = "0x2A26C9C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016471")]
	[Address(RVA = "0x2A26FC4", Offset = "0x2A26FC4", VA = "0x2A26FC4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
