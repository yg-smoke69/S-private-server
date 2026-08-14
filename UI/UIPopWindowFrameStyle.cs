using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20022AB")]
public class UIPopWindowFrameStyle : MonoBehaviour
{
	[Token(Token = "0x400D8F8")]
	[FieldOffset(Offset = "0xC")]
	public UIPopupWindowController parentPopupWindow;

	[Token(Token = "0x400D8F9")]
	[FieldOffset(Offset = "0x10")]
	public UIFrameSize frameSize;

	[Token(Token = "0x400D8FA")]
	[FieldOffset(Offset = "0x14")]
	public string titleKey;

	[Token(Token = "0x400D8FB")]
	[FieldOffset(Offset = "0x18")]
	public bool unuseCloseBtn;

	[Token(Token = "0x400D8FC")]
	[FieldOffset(Offset = "0x1C")]
	public UIPopWindowFrameController frameController;

	[Token(Token = "0x600BE98")]
	[Address(RVA = "0x22422E8", Offset = "0x22422E8", VA = "0x22422E8")]
	public UIPopWindowFrameStyle()
	{
	}

	[Token(Token = "0x600BE99")]
	[Address(RVA = "0x22422F0", Offset = "0x22422F0", VA = "0x22422F0")]
	public void InitStyle(GameObject framePrefab, UIBaseController parentController)
	{
	}

	[Token(Token = "0x600BE9A")]
	[Address(RVA = "0x2242424", Offset = "0x2242424", VA = "0x2242424")]
	public static ResourceID GetFrameResourceId(UIFrameSize size)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BE9B")]
	[Address(RVA = "0x2242570", Offset = "0x2242570", VA = "0x2242570")]
	public void UpdateFrameTitleKey(string newKey)
	{
	}

	[Token(Token = "0x600BE9C")]
	[Address(RVA = "0x2242684", Offset = "0x2242684", VA = "0x2242684")]
	public void UpdateCloseBtnView(bool isShow)
	{
	}
}
