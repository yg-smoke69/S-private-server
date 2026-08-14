using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034DF")]
public class UIDigitaluniverseBStarMapAssistHistoryItemView : UIBaseView
{
	[Token(Token = "0x4014C61")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ProfileIcon;

	[Token(Token = "0x4014C62")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelName;

	[Token(Token = "0x4014C63")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelToken;

	[Token(Token = "0x4014C64")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnAssist;

	[Token(Token = "0x4014C65")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Assisted;

	[Token(Token = "0x4014C66")]
	[FieldOffset(Offset = "0x28")]
	public UISprite AssistBg;

	[Token(Token = "0x601624F")]
	[Address(RVA = "0x2F0F3C0", Offset = "0x2F0F3C0", VA = "0x2F0F3C0")]
	public UIDigitaluniverseBStarMapAssistHistoryItemView()
	{
	}

	[Token(Token = "0x6016250")]
	[Address(RVA = "0x2F0F3C8", Offset = "0x2F0F3C8", VA = "0x2F0F3C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016251")]
	[Address(RVA = "0x2F0F744", Offset = "0x2F0F744", VA = "0x2F0F744")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
