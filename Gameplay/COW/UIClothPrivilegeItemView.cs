using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200346D")]
public class UIClothPrivilegeItemView : UIBaseView
{
	[Token(Token = "0x4014633")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIClothPrivilegeItem;

	[Token(Token = "0x4014634")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SpritePrivilege;

	[Token(Token = "0x4014635")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabePrivilege;

	[Token(Token = "0x4014636")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelDesc;

	[Token(Token = "0x60160FB")]
	[Address(RVA = "0x2CD2090", Offset = "0x2CD2090", VA = "0x2CD2090")]
	public UIClothPrivilegeItemView()
	{
	}

	[Token(Token = "0x60160FC")]
	[Address(RVA = "0x2CD2098", Offset = "0x2CD2098", VA = "0x2CD2098", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160FD")]
	[Address(RVA = "0x2CD2354", Offset = "0x2CD2354", VA = "0x2CD2354")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
