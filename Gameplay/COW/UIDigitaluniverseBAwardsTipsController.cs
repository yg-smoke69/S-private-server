using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001EAB")]
public class UIDigitaluniverseBAwardsTipsController : UIPopupWindowController
{
	[Token(Token = "0x400C0ED")]
	[FieldOffset(Offset = "0x48")]
	private UIDigitaluniverseBAwardsTipsView m_View;

	[Token(Token = "0x400C0EE")]
	[FieldOffset(Offset = "0x4C")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x400C0EF")]
	private const float HEIGHTSPACE = 20f;

	[Token(Token = "0x600945E")]
	[Address(RVA = "0x2AC49FC", Offset = "0x2AC49FC", VA = "0x2AC49FC")]
	public UIDigitaluniverseBAwardsTipsController()
	{
	}

	[Token(Token = "0x600945F")]
	[Address(RVA = "0x2AC4A04", Offset = "0x2AC4A04", VA = "0x2AC4A04")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009460")]
	[Address(RVA = "0x2AC4AAC", Offset = "0x2AC4AAC", VA = "0x2AC4AAC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009461")]
	[Address(RVA = "0x2AC4BD8", Offset = "0x2AC4BD8", VA = "0x2AC4BD8")]
	public void SetView(List<AwardDesc> awardList, bool hasClaim, uint progress, int gateType = 4)
	{
	}

	[Token(Token = "0x6009462")]
	[Address(RVA = "0x2AC50E0", Offset = "0x2AC50E0", VA = "0x2AC50E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
