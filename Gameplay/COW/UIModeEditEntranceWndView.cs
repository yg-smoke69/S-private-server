using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038B0")]
public class UIModeEditEntranceWndView : UIBaseView
{
	[Token(Token = "0x401771A")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Classic;

	[Token(Token = "0x401771B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ClassicDefaultIcon;

	[Token(Token = "0x401771C")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture ClassicCDNIcon;

	[Token(Token = "0x401771D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ClassicLastTime;

	[Token(Token = "0x401771E")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Custom;

	[Token(Token = "0x401771F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CustomDefaultIcon;

	[Token(Token = "0x4017720")]
	[FieldOffset(Offset = "0x2C")]
	public UINetworkTexture CustomCDNIcon;

	[Token(Token = "0x4017721")]
	[FieldOffset(Offset = "0x30")]
	public GameObject CustomLastTime;

	[Token(Token = "0x4017722")]
	[FieldOffset(Offset = "0x34")]
	public UIButton CustomLock;

	[Token(Token = "0x6016DBB")]
	[Address(RVA = "0x130FD54", Offset = "0x130FD54", VA = "0x130FD54")]
	public UIModeEditEntranceWndView()
	{
	}

	[Token(Token = "0x6016DBC")]
	[Address(RVA = "0x130FD5C", Offset = "0x130FD5C", VA = "0x130FD5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DBD")]
	[Address(RVA = "0x13101D4", Offset = "0x13101D4", VA = "0x13101D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
