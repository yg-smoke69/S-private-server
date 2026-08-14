using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034D8")]
public class UIDigitaluniverseBNormalAwardItemView : UIBaseView
{
	[Token(Token = "0x4014BF8")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ItemLabel;

	[Token(Token = "0x4014BF9")]
	[FieldOffset(Offset = "0x18")]
	public GameObject VFX;

	[Token(Token = "0x4014BFA")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject BoxReceivedContainer;

	[Token(Token = "0x4014BFB")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnClick;

	[Token(Token = "0x4014BFC")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BoxAvailableContainer;

	[Token(Token = "0x4014BFD")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BoxNormalContainer;

	[Token(Token = "0x601623A")]
	[Address(RVA = "0x2EFE258", Offset = "0x2EFE258", VA = "0x2EFE258")]
	public UIDigitaluniverseBNormalAwardItemView()
	{
	}

	[Token(Token = "0x601623B")]
	[Address(RVA = "0x2EFE260", Offset = "0x2EFE260", VA = "0x2EFE260", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601623C")]
	[Address(RVA = "0x2EFE5B8", Offset = "0x2EFE5B8", VA = "0x2EFE5B8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
