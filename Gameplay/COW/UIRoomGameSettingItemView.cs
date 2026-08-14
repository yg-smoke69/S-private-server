using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003964")]
public class UIRoomGameSettingItemView : UIBaseView
{
	[Token(Token = "0x4018051")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Text;

	[Token(Token = "0x4018052")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4018053")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject PredictToolEnable;

	[Token(Token = "0x4018054")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PredictToolDisable;

	[Token(Token = "0x4018055")]
	[FieldOffset(Offset = "0x24")]
	public GameObject TrapEnable;

	[Token(Token = "0x4018056")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TrapDisable;

	[Token(Token = "0x6016FD3")]
	[Address(RVA = "0x23C0B94", Offset = "0x23C0B94", VA = "0x23C0B94")]
	public UIRoomGameSettingItemView()
	{
	}

	[Token(Token = "0x6016FD4")]
	[Address(RVA = "0x23C0B9C", Offset = "0x23C0B9C", VA = "0x23C0B9C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FD5")]
	[Address(RVA = "0x23C0EF4", Offset = "0x23C0EF4", VA = "0x23C0EF4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
