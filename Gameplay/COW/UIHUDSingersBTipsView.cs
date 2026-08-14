using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200374A")]
public class UIHUDSingersBTipsView : UIBaseView
{
	[Token(Token = "0x40165B8")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel UIHUDSingersBTips;

	[Token(Token = "0x40165B9")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Bg;

	[Token(Token = "0x40165BA")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Label;

	[Token(Token = "0x6016989")]
	[Address(RVA = "0x2214A48", Offset = "0x2214A48", VA = "0x2214A48")]
	public UIHUDSingersBTipsView()
	{
	}

	[Token(Token = "0x601698A")]
	[Address(RVA = "0x2214A50", Offset = "0x2214A50", VA = "0x2214A50", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601698B")]
	[Address(RVA = "0x2214CAC", Offset = "0x2214CAC", VA = "0x2214CAC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
