using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AD5")]
public class UIRewardPreviewItemController : UIBaseController
{
	[Token(Token = "0x401071B")]
	[FieldOffset(Offset = "0x28")]
	private UIRewardPreviewItemView m_View;

	[Token(Token = "0x60118DE")]
	[Address(RVA = "0x1E5811C", Offset = "0x1E5811C", VA = "0x1E5811C")]
	public UIRewardPreviewItemController()
	{
	}

	[Token(Token = "0x60118DF")]
	[Address(RVA = "0x1E581A0", Offset = "0x1E581A0", VA = "0x1E581A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60118E0")]
	[Address(RVA = "0x1E58244", Offset = "0x1E58244", VA = "0x1E58244", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60118E1")]
	[Address(RVA = "0x1E58338", Offset = "0x1E58338", VA = "0x1E58338")]
	public void SetViewData(BaseItemInfo desc)
	{
	}

	[Token(Token = "0x60118E2")]
	[Address(RVA = "0x1E583E0", Offset = "0x1E583E0", VA = "0x1E583E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
