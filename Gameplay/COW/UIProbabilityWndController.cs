using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A82")]
public class UIProbabilityWndController : UIPopupWindowController
{
	[Token(Token = "0x2002A83")]
	private sealed class _003CSetViewData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010523")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemId;

		[Token(Token = "0x4010524")]
		[FieldOffset(Offset = "0xC")]
		internal UIProbabilityWndController _0024this;

		[Token(Token = "0x6011500")]
		[Address(RVA = "0xF03444", Offset = "0xF03444", VA = "0xF03444")]
		public _003CSetViewData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6011501")]
		[Address(RVA = "0xF037EC", Offset = "0xF037EC", VA = "0xF037EC")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6011502")]
		[Address(RVA = "0xF038FC", Offset = "0xF038FC", VA = "0xF038FC")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x4010521")]
	[FieldOffset(Offset = "0x48")]
	private UIProbabilityWndView m_View;

	[Token(Token = "0x4010522")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x60114FA")]
	[Address(RVA = "0xF02FE8", Offset = "0xF02FE8", VA = "0xF02FE8")]
	public UIProbabilityWndController()
	{
	}

	[Token(Token = "0x60114FB")]
	[Address(RVA = "0xF02FF0", Offset = "0xF02FF0", VA = "0xF02FF0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60114FC")]
	[Address(RVA = "0xF03094", Offset = "0xF03094", VA = "0xF03094", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60114FD")]
	[Address(RVA = "0xF031F0", Offset = "0xF031F0", VA = "0xF031F0")]
	public void SetViewData(uint itemId)
	{
	}

	[Token(Token = "0x60114FE")]
	[Address(RVA = "0xF0344C", Offset = "0xF0344C", VA = "0xF0344C")]
	private void ShowProbabilty(List<RareProbability> rare_pr, List<ItemProbability> item_pr, List<AwardTypeProbability> award_type_pr)
	{
	}

	[Token(Token = "0x60114FF")]
	[Address(RVA = "0xF037E4", Offset = "0xF037E4", VA = "0xF037E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
