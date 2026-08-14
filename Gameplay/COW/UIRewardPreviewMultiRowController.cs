using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AD7")]
public class UIRewardPreviewMultiRowController : UIPopupWindowController
{
	[Token(Token = "0x401071D")]
	[FieldOffset(Offset = "0x48")]
	private UIRewardPreviewMultiRowView m_View;

	[Token(Token = "0x60118E9")]
	[Address(RVA = "0x1E58F14", Offset = "0x1E58F14", VA = "0x1E58F14")]
	public UIRewardPreviewMultiRowController()
	{
	}

	[Token(Token = "0x60118EA")]
	[Address(RVA = "0x1E58F1C", Offset = "0x1E58F1C", VA = "0x1E58F1C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60118EB")]
	[Address(RVA = "0x1E58FC0", Offset = "0x1E58FC0", VA = "0x1E58FC0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60118EC")]
	[Address(RVA = "0x1E5911C", Offset = "0x1E5911C", VA = "0x1E5911C")]
	public void SetViewData(List<List<List<BaseItemInfo>>> infos, List<string> desc, [Optional] string title, [Optional] string btnLabel)
	{
	}

	[Token(Token = "0x60118ED")]
	[Address(RVA = "0x1E59470", Offset = "0x1E59470", VA = "0x1E59470")]
	private void OnOKClick()
	{
	}

	[Token(Token = "0x60118EE")]
	[Address(RVA = "0x1E594D4", Offset = "0x1E594D4", VA = "0x1E594D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
