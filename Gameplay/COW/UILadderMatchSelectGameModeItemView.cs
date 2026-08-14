using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003812")]
public class UILadderMatchSelectGameModeItemView : UIBaseView
{
	[Token(Token = "0x4016CF5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnMode;

	[Token(Token = "0x4016CF6")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelName;

	[Token(Token = "0x4016CF7")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture TextureBg;

	[Token(Token = "0x4016CF8")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelTime;

	[Token(Token = "0x4016CF9")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelSeason;

	[Token(Token = "0x6016BE1")]
	[Address(RVA = "0x22D7AFC", Offset = "0x22D7AFC", VA = "0x22D7AFC")]
	public UILadderMatchSelectGameModeItemView()
	{
	}

	[Token(Token = "0x6016BE2")]
	[Address(RVA = "0x22D7B04", Offset = "0x22D7B04", VA = "0x22D7B04", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BE3")]
	[Address(RVA = "0x22D7E2C", Offset = "0x22D7E2C", VA = "0x22D7E2C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
