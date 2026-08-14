using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037A9")]
public class UIHUDUGC_SceneObjectEntityAttributeEditItemView : UIBaseView
{
	[Token(Token = "0x40168A0")]
	[FieldOffset(Offset = "0x14")]
	public Transform BoolValue;

	[Token(Token = "0x40168A1")]
	[FieldOffset(Offset = "0x18")]
	public GameObject StandardValue;

	[Token(Token = "0x40168A2")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput StandardInputValue;

	[Token(Token = "0x40168A3")]
	[FieldOffset(Offset = "0x20")]
	public UILabel name;

	[Token(Token = "0x6016AA6")]
	[Address(RVA = "0x291DD84", Offset = "0x291DD84", VA = "0x291DD84")]
	public UIHUDUGC_SceneObjectEntityAttributeEditItemView()
	{
	}

	[Token(Token = "0x6016AA7")]
	[Address(RVA = "0x291DD8C", Offset = "0x291DD8C", VA = "0x291DD8C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AA8")]
	[Address(RVA = "0x291E020", Offset = "0x291E020", VA = "0x291E020")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
