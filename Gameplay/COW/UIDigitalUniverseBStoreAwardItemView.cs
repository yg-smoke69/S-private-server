using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034E6")]
public class UIDigitalUniverseBStoreAwardItemView : UIBaseView
{
	[Token(Token = "0x4014C96")]
	[FieldOffset(Offset = "0x14")]
	public GameObject MaskBlack;

	[Token(Token = "0x4014C97")]
	[FieldOffset(Offset = "0x18")]
	public GameObject MaskPink;

	[Token(Token = "0x4014C98")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelNormalDoorDate;

	[Token(Token = "0x4014C99")]
	[FieldOffset(Offset = "0x20")]
	public Transform Item;

	[Token(Token = "0x4014C9A")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnGOTO;

	[Token(Token = "0x4014C9B")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelNormalDoorName;

	[Token(Token = "0x4014C9C")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NormalContainer;

	[Token(Token = "0x4014C9D")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LockContainer;

	[Token(Token = "0x4014C9E")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LabeLockDoorDate;

	[Token(Token = "0x4014C9F")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LabelLockDoorName;

	[Token(Token = "0x6016264")]
	[Address(RVA = "0x2D8705C", Offset = "0x2D8705C", VA = "0x2D8705C")]
	public UIDigitalUniverseBStoreAwardItemView()
	{
	}

	[Token(Token = "0x6016265")]
	[Address(RVA = "0x2D87064", Offset = "0x2D87064", VA = "0x2D87064", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016266")]
	[Address(RVA = "0x2D87514", Offset = "0x2D87514", VA = "0x2D87514")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
