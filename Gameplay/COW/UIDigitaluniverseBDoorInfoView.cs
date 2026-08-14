using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034CE")]
public class UIDigitaluniverseBDoorInfoView : UIBaseView
{
	[Token(Token = "0x4014B27")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelOpenDay;

	[Token(Token = "0x4014B28")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelDate;

	[Token(Token = "0x4014B29")]
	[FieldOffset(Offset = "0x1C")]
	public Transform UIDigitaluniverseBDoorInfo;

	[Token(Token = "0x4014B2A")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelDoorName;

	[Token(Token = "0x4014B2B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject DateBgContainer;

	[Token(Token = "0x601621E")]
	[Address(RVA = "0x2AE28D4", Offset = "0x2AE28D4", VA = "0x2AE28D4")]
	public UIDigitaluniverseBDoorInfoView()
	{
	}

	[Token(Token = "0x601621F")]
	[Address(RVA = "0x2AE28DC", Offset = "0x2AE28DC", VA = "0x2AE28DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016220")]
	[Address(RVA = "0x2AE2BD0", Offset = "0x2AE2BD0", VA = "0x2AE2BD0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
