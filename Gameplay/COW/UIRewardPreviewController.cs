using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AD4")]
public class UIRewardPreviewController : UIPopupWindowController
{
	[Token(Token = "0x401071A")]
	[FieldOffset(Offset = "0x48")]
	private UIRewardPreviewView m_View;

	[Token(Token = "0x60118D8")]
	[Address(RVA = "0x1E57B5C", Offset = "0x1E57B5C", VA = "0x1E57B5C")]
	public UIRewardPreviewController()
	{
	}

	[Token(Token = "0x60118D9")]
	[Address(RVA = "0x1E57B64", Offset = "0x1E57B64", VA = "0x1E57B64")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60118DA")]
	[Address(RVA = "0x1E57C08", Offset = "0x1E57C08", VA = "0x1E57C08", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60118DB")]
	[Address(RVA = "0x1E57D64", Offset = "0x1E57D64", VA = "0x1E57D64")]
	public void SetViewData(List<BaseItemInfo> infos, [Optional] string title, [Optional] string desc, [Optional] string btnLabel)
	{
	}

	[Token(Token = "0x60118DC")]
	[Address(RVA = "0x1E580B0", Offset = "0x1E580B0", VA = "0x1E580B0")]
	private void OnOKClick()
	{
	}

	[Token(Token = "0x60118DD")]
	[Address(RVA = "0x1E58114", Offset = "0x1E58114", VA = "0x1E58114")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
