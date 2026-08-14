using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F07")]
public class UIDigitaluniverseBStoreAwardsWndController : UIPopupWindowController
{
	[Token(Token = "0x400C342")]
	[FieldOffset(Offset = "0x48")]
	private UIDigitaluniverseBStoreAwardsWndView m_View;

	[Token(Token = "0x400C343")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIDigitalUniverseBStoreAwardItemController> m_AwardsStoreItemList;

	[Token(Token = "0x400C344")]
	[FieldOffset(Offset = "0x50")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C345")]
	[FieldOffset(Offset = "0x54")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x60097E1")]
	[Address(RVA = "0x2F1AC88", Offset = "0x2F1AC88", VA = "0x2F1AC88")]
	public UIDigitaluniverseBStoreAwardsWndController()
	{
	}

	[Token(Token = "0x60097E2")]
	[Address(RVA = "0x2F1AD14", Offset = "0x2F1AD14", VA = "0x2F1AD14")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60097E3")]
	[Address(RVA = "0x2F1ADBC", Offset = "0x2F1ADBC", VA = "0x2F1ADBC")]
	private ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x60097E4")]
	[Address(RVA = "0x2F1AE14", Offset = "0x2F1AE14", VA = "0x2F1AE14", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60097E5")]
	[Address(RVA = "0x2F1B1E8", Offset = "0x2F1B1E8", VA = "0x2F1B1E8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
