using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003671")]
internal class UIHudHyakkiTeammatesInfoView : UIBaseView
{
	[Token(Token = "0x4015D99")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid Grid;

	[Token(Token = "0x4015D9A")]
	[FieldOffset(Offset = "0x18")]
	public UIHudHyakkiTeammateItem TeammateTemplate;

	[Token(Token = "0x6016700")]
	[Address(RVA = "0x134C42C", Offset = "0x134C42C", VA = "0x134C42C")]
	public UIHudHyakkiTeammatesInfoView()
	{
	}

	[Token(Token = "0x6016701")]
	[Address(RVA = "0x134C434", Offset = "0x134C434", VA = "0x134C434", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016702")]
	[Address(RVA = "0x134C63C", Offset = "0x134C63C", VA = "0x134C63C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
