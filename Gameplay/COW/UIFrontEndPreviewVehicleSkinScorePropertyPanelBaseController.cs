using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CCB")]
public abstract class UIFrontEndPreviewVehicleSkinScorePropertyPanelBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewVehicleSkinScorePropertyPanelBaseView>
{
	[Token(Token = "0x4011164")]
	[FieldOffset(Offset = "0x38")]
	private List<UICollectionVehicleSkinScoreItemController> m_VeicleSkinScoreList;

	[Token(Token = "0x6012BFB")]
	[Address(RVA = "0xE9013C", Offset = "0xE9013C", VA = "0xE9013C")]
	protected UIFrontEndPreviewVehicleSkinScorePropertyPanelBaseController()
	{
	}

	[Token(Token = "0x6012BFC")]
	[Address(RVA = "0xE901D4", Offset = "0xE901D4", VA = "0xE901D4", Slot = "32")]
	protected override void InitView()
	{
	}

	[Token(Token = "0x6012BFD")]
	[Address(RVA = "0xE90234", Offset = "0xE90234", VA = "0xE90234")]
	public bool RefreshVehicleSkinPropertyScore(uint itemid)
	{
		return default(bool);
	}

	[Token(Token = "0x6012BFE")]
	[Address(RVA = "0xE90DC8", Offset = "0xE90DC8", VA = "0xE90DC8")]
	public void RepositionProperty()
	{
	}

	[Token(Token = "0x6012BFF")]
	[Address(RVA = "0xE90E90", Offset = "0xE90E90", VA = "0xE90E90")]
	public void _003C_003EiFixBaseProxy_InitView()
	{
	}
}
