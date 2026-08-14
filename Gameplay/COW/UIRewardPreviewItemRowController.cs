using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AD6")]
public class UIRewardPreviewItemRowController : UIPopupWindowController
{
	[Token(Token = "0x401071C")]
	[FieldOffset(Offset = "0x48")]
	private UIRewardPreviewItemRowView m_View;

	[Token(Token = "0x60118E3")]
	[Address(RVA = "0x1E583E8", Offset = "0x1E583E8", VA = "0x1E583E8")]
	public UIRewardPreviewItemRowController()
	{
	}

	[Token(Token = "0x60118E4")]
	[Address(RVA = "0x1E583F0", Offset = "0x1E583F0", VA = "0x1E583F0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60118E5")]
	[Address(RVA = "0x1E58494", Offset = "0x1E58494", VA = "0x1E58494", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60118E6")]
	[Address(RVA = "0x1E58550", Offset = "0x1E58550", VA = "0x1E58550")]
	public void SetViewData(List<List<BaseItemInfo>> infos, [Optional] string desc)
	{
	}

	[Token(Token = "0x60118E7")]
	[Address(RVA = "0x1E588A4", Offset = "0x1E588A4", VA = "0x1E588A4")]
	private void OnOKClick()
	{
	}

	[Token(Token = "0x60118E8")]
	[Address(RVA = "0x1E58908", Offset = "0x1E58908", VA = "0x1E58908")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
