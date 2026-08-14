using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200382F")]
public class UILiveTvView : UIBaseView
{
	[Token(Token = "0x4016E8B")]
	[FieldOffset(Offset = "0x14")]
	public UIToggleButton LiveTv;

	[Token(Token = "0x4016E8C")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LiveSelectLabel;

	[Token(Token = "0x4016E8D")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LiveUnSelectLabel;

	[Token(Token = "0x4016E8E")]
	[FieldOffset(Offset = "0x20")]
	public UIToggleButton BooyahTv;

	[Token(Token = "0x4016E8F")]
	[FieldOffset(Offset = "0x24")]
	public UILabel BooyahUnSelectLabel;

	[Token(Token = "0x4016E90")]
	[FieldOffset(Offset = "0x28")]
	public UILabel BooyahSelectLabel;

	[Token(Token = "0x4016E91")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnRefresh;

	[Token(Token = "0x6016C38")]
	[Address(RVA = "0x214E738", Offset = "0x214E738", VA = "0x214E738")]
	public UILiveTvView()
	{
	}

	[Token(Token = "0x6016C39")]
	[Address(RVA = "0x214E740", Offset = "0x214E740", VA = "0x214E740", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C3A")]
	[Address(RVA = "0x214EB28", Offset = "0x214EB28", VA = "0x214EB28")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
