using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033F0")]
public class UIBigEvent_GlobalProgress_MissionItemView : UIBaseView
{
	[Token(Token = "0x4013FBC")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelDescription;

	[Token(Token = "0x4013FBD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LabelReceived;

	[Token(Token = "0x4013FBE")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnReceive;

	[Token(Token = "0x4013FBF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GoAwarded;

	[Token(Token = "0x4013FC0")]
	[FieldOffset(Offset = "0x24")]
	public UINetworkTexture TextureBg;

	[Token(Token = "0x4013FC1")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelProcess;

	[Token(Token = "0x4013FC2")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid GridAwards;

	[Token(Token = "0x6015F84")]
	[Address(RVA = "0x10BE0B8", Offset = "0x10BE0B8", VA = "0x10BE0B8")]
	public UIBigEvent_GlobalProgress_MissionItemView()
	{
	}

	[Token(Token = "0x6015F85")]
	[Address(RVA = "0x10BE0C0", Offset = "0x10BE0C0", VA = "0x10BE0C0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F86")]
	[Address(RVA = "0x10BE490", Offset = "0x10BE490", VA = "0x10BE490")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
