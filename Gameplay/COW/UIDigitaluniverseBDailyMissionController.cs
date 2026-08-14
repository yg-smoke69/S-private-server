using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001EBD")]
internal class UIDigitaluniverseBDailyMissionController : UIBaseController
{
	[Token(Token = "0x400C17C")]
	[FieldOffset(Offset = "0x28")]
	private UIDigitalUniverseBDailyMissionView m_View;

	[Token(Token = "0x400C17D")]
	private const uint DAILYMISSIONWIDTH = 798u;

	[Token(Token = "0x400C17E")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_data;

	[Token(Token = "0x400C17F")]
	[FieldOffset(Offset = "0x30")]
	private List<UIStandardItemMiniController> m_ItemMiniList;

	[Token(Token = "0x400C180")]
	[FieldOffset(Offset = "0x34")]
	private UIModelActivity m_ModelAactivity;

	[Token(Token = "0x400C181")]
	[FieldOffset(Offset = "0x38")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x600954C")]
	[Address(RVA = "0x2ADFD38", Offset = "0x2ADFD38", VA = "0x2ADFD38")]
	public UIDigitaluniverseBDailyMissionController()
	{
	}

	[Token(Token = "0x600954D")]
	[Address(RVA = "0x2ADFDF0", Offset = "0x2ADFDF0", VA = "0x2ADFDF0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600954E")]
	[Address(RVA = "0x2ADFE98", Offset = "0x2ADFE98", VA = "0x2ADFE98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600954F")]
	[Address(RVA = "0x2AE0180", Offset = "0x2AE0180", VA = "0x2AE0180")]
	public void SetViewData(uint index)
	{
	}

	[Token(Token = "0x6009550")]
	[Address(RVA = "0x2AE01F0", Offset = "0x2AE01F0", VA = "0x2AE01F0")]
	private void ResetItem(uint index)
	{
	}

	[Token(Token = "0x6009551")]
	[Address(RVA = "0x2AE129C", Offset = "0x2AE129C", VA = "0x2AE129C")]
	private void ClaimActivityAward()
	{
	}

	[Token(Token = "0x6009552")]
	[Address(RVA = "0x2AE15B8", Offset = "0x2AE15B8", VA = "0x2AE15B8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
