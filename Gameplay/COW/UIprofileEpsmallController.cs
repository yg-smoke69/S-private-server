using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A99")]
public class UIprofileEpsmallController : UIBaseController
{
	[Token(Token = "0x40105CA")]
	[FieldOffset(Offset = "0x28")]
	private UIProfileEPSMallItemView m_View;

	[Token(Token = "0x40105CB")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_EPEventId;

	[Token(Token = "0x40105CC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly List<CSVBaseData> m_EPDataList;

	[Token(Token = "0x40105CD")]
	private const uint EVENT_BASE = 1001000000u;

	[Token(Token = "0x6011659")]
	[Address(RVA = "0x1A36870", Offset = "0x1A36870", VA = "0x1A36870")]
	public UIprofileEpsmallController()
	{
	}

	[Token(Token = "0x601165A")]
	[Address(RVA = "0x1A368F4", Offset = "0x1A368F4", VA = "0x1A368F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601165B")]
	[Address(RVA = "0x1A36998", Offset = "0x1A36998", VA = "0x1A36998", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601165C")]
	[Address(RVA = "0x1A36AEC", Offset = "0x1A36AEC", VA = "0x1A36AEC")]
	public void RefreshData(BasicEPInfo info)
	{
	}

	[Token(Token = "0x601165D")]
	[Address(RVA = "0x1A36E10", Offset = "0x1A36E10", VA = "0x1A36E10", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x601165E")]
	[Address(RVA = "0x1A36F10", Offset = "0x1A36F10", VA = "0x1A36F10")]
	private void OnTipsButtonHover(bool flag)
	{
	}

	[Token(Token = "0x6011660")]
	[Address(RVA = "0x1A37478", Offset = "0x1A37478", VA = "0x1A37478")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011661")]
	[Address(RVA = "0x1A37480", Offset = "0x1A37480", VA = "0x1A37480")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
