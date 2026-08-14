using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002689")]
public class UILegendGachaReRandomConfirmWndController : UIPopupWindowController
{
	[Token(Token = "0x400EDD9")]
	[FieldOffset(Offset = "0x48")]
	private uint m_GachaID;

	[Token(Token = "0x400EDDA")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelGacha m_Model;

	[Token(Token = "0x400EDDB")]
	[FieldOffset(Offset = "0x50")]
	private UILegendGachaReRandomConfirmWndView m_View;

	[Token(Token = "0x400EDDC")]
	[FieldOffset(Offset = "0x54")]
	private List<uint> m_List;

	[Token(Token = "0x400EDDD")]
	[FieldOffset(Offset = "0x58")]
	private GachaDesc m_GachaDesc;

	[Token(Token = "0x600E74F")]
	[Address(RVA = "0x254876C", Offset = "0x254876C", VA = "0x254876C")]
	public UILegendGachaReRandomConfirmWndController()
	{
	}

	[Token(Token = "0x600E750")]
	[Address(RVA = "0x2548774", Offset = "0x2548774", VA = "0x2548774")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E751")]
	[Address(RVA = "0x2548818", Offset = "0x2548818", VA = "0x2548818", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E752")]
	[Address(RVA = "0x2548AE8", Offset = "0x2548AE8", VA = "0x2548AE8")]
	private void OnToggleClick()
	{
	}

	[Token(Token = "0x600E753")]
	[Address(RVA = "0x2548BD4", Offset = "0x2548BD4", VA = "0x2548BD4")]
	public void SetView(uint gachaID, string text, List<uint> list)
	{
	}

	[Token(Token = "0x600E754")]
	[Address(RVA = "0x2548E0C", Offset = "0x2548E0C", VA = "0x2548E0C")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x600E755")]
	[Address(RVA = "0x2548F08", Offset = "0x2548F08", VA = "0x2548F08")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
