using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F4D")]
public class UIActivityAnnouncementController : UIActivityBaseController
{
	[Token(Token = "0x2001F4E")]
	private sealed class _003CSelectItem_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C4CA")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6009ABE")]
		[Address(RVA = "0x2A04C74", Offset = "0x2A04C74", VA = "0x2A04C74")]
		public _003CSelectItem_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6009ABF")]
		[Address(RVA = "0x2A06300", Offset = "0x2A06300", VA = "0x2A06300")]
		internal bool _003C_003Em__0(AnnoucementInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F4F")]
	private sealed class _003CSetData_003Ec__AnonStorey1
	{
		[Token(Token = "0x400C4CB")]
		[FieldOffset(Offset = "0x8")]
		internal StandardTabItemViewData tabData;

		[Token(Token = "0x400C4CC")]
		[FieldOffset(Offset = "0xC")]
		internal UIActivityAnnouncementController _0024this;

		[Token(Token = "0x6009AC0")]
		[Address(RVA = "0x2A05814", Offset = "0x2A05814", VA = "0x2A05814")]
		public _003CSetData_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6009AC1")]
		[Address(RVA = "0x2A0634C", Offset = "0x2A0634C", VA = "0x2A0634C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400C4C2")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityAnnouncementView m_View;

	[Token(Token = "0x400C4C3")]
	[FieldOffset(Offset = "0x2C")]
	private List<AnnoucementInfo> m_GroupDescs;

	[Token(Token = "0x400C4C4")]
	[FieldOffset(Offset = "0x30")]
	private AnnoucementInfo m_SelectInfo;

	[Token(Token = "0x400C4C5")]
	[FieldOffset(Offset = "0x34")]
	private CommunityWebsiteData m_websiteData;

	[Token(Token = "0x400C4C6")]
	[FieldOffset(Offset = "0x38")]
	private UIModelAnnouncement m_ModelAnnouncement;

	[Token(Token = "0x400C4C7")]
	[FieldOffset(Offset = "0x3C")]
	private List<StandardTabItemViewData> m_TabDataList;

	[Token(Token = "0x400C4C8")]
	[FieldOffset(Offset = "0x40")]
	private UIStandardTabController m_TabCtrl;

	[Token(Token = "0x400C4C9")]
	[FieldOffset(Offset = "0x44")]
	private UIActivityADContentController m_ADCtrl;

	[Token(Token = "0x6009AAC")]
	[Address(RVA = "0x2A03F74", Offset = "0x2A03F74", VA = "0x2A03F74")]
	public UIActivityAnnouncementController()
	{
	}

	[Token(Token = "0x6009AAD")]
	[Address(RVA = "0x2A04080", Offset = "0x2A04080", VA = "0x2A04080")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009AAE")]
	[Address(RVA = "0x2A04124", Offset = "0x2A04124", VA = "0x2A04124", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009AAF")]
	[Address(RVA = "0x2A04A9C", Offset = "0x2A04A9C", VA = "0x2A04A9C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6009AB0")]
	[Address(RVA = "0x2A04B00", Offset = "0x2A04B00", VA = "0x2A04B00", Slot = "32")]
	public override void SelectItem(uint id)
	{
	}

	[Token(Token = "0x6009AB1")]
	[Address(RVA = "0x2A04C7C", Offset = "0x2A04C7C", VA = "0x2A04C7C")]
	public void ActivityGroupSelected(AnnoucementInfo info)
	{
	}

	[Token(Token = "0x6009AB2")]
	[Address(RVA = "0x2A05384", Offset = "0x2A05384", VA = "0x2A05384", Slot = "31")]
	public override void SetData(object data)
	{
	}

	[Token(Token = "0x6009AB3")]
	[Address(RVA = "0x2A0581C", Offset = "0x2A0581C", VA = "0x2A0581C")]
	private void OnTabItemSelect(StandardTabItemViewData viewData)
	{
	}

	[Token(Token = "0x6009AB4")]
	[Address(RVA = "0x2A059F8", Offset = "0x2A059F8", VA = "0x2A059F8")]
	private void OnOperate()
	{
	}

	[Token(Token = "0x6009AB5")]
	[Address(RVA = "0x2A05E0C", Offset = "0x2A05E0C", VA = "0x2A05E0C")]
	private void OpenCommunityWebsite(bool facebook = false, bool offical = false, bool ins = false)
	{
	}

	[Token(Token = "0x6009AB6")]
	[Address(RVA = "0x2A04648", Offset = "0x2A04648", VA = "0x2A04648")]
	private CommunityWebsiteData GetCommunityWebsiteData()
	{
		return null;
	}

	[Token(Token = "0x6009AB7")]
	[Address(RVA = "0x2A061C4", Offset = "0x2A061C4", VA = "0x2A061C4")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x6009AB8")]
	[Address(RVA = "0x2A061E8", Offset = "0x2A061E8", VA = "0x2A061E8")]
	private void _003COnUIInit_003Em__1()
	{
	}

	[Token(Token = "0x6009AB9")]
	[Address(RVA = "0x2A0620C", Offset = "0x2A0620C", VA = "0x2A0620C")]
	private void _003COnUIInit_003Em__2()
	{
	}

	[Token(Token = "0x6009ABA")]
	[Address(RVA = "0x2A06230", Offset = "0x2A06230", VA = "0x2A06230")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009ABB")]
	[Address(RVA = "0x2A06238", Offset = "0x2A06238", VA = "0x2A06238")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6009ABC")]
	[Address(RVA = "0x2A06240", Offset = "0x2A06240", VA = "0x2A06240")]
	public void _003C_003EiFixBaseProxy_SelectItem(uint P0)
	{
	}

	[Token(Token = "0x6009ABD")]
	[Address(RVA = "0x2A062A0", Offset = "0x2A062A0", VA = "0x2A062A0")]
	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}
}
