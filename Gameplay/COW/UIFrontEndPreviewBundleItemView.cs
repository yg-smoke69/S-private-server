using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200354E")]
public class UIFrontEndPreviewBundleItemView : UIBaseView
{
	[Token(Token = "0x40151FA")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x40151FB")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Owned;

	[Token(Token = "0x40151FC")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel OwnedLabel;

	[Token(Token = "0x40151FD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Descargar;

	[Token(Token = "0x40151FE")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BGSelected;

	[Token(Token = "0x601639A")]
	[Address(RVA = "0x27E0214", Offset = "0x27E0214", VA = "0x27E0214")]
	public UIFrontEndPreviewBundleItemView()
	{
	}

	[Token(Token = "0x601639B")]
	[Address(RVA = "0x27E021C", Offset = "0x27E021C", VA = "0x27E021C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601639C")]
	[Address(RVA = "0x27E0520", Offset = "0x27E0520", VA = "0x27E0520")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
