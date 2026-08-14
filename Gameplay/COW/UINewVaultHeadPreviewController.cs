using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A00")]
internal class UINewVaultHeadPreviewController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002A01")]
	private sealed class _003CSetHotFixDownload_003Ec__AnonStorey0
	{
		[Token(Token = "0x401029C")]
		[FieldOffset(Offset = "0x8")]
		internal List<ResourceID> res_list;

		[Token(Token = "0x401029D")]
		[FieldOffset(Offset = "0xC")]
		internal string tempname;

		[Token(Token = "0x401029E")]
		[FieldOffset(Offset = "0x10")]
		internal UINewVaultHeadPreviewController _0024this;

		[Token(Token = "0x6010F83")]
		[Address(RVA = "0x26C705C", Offset = "0x26C705C", VA = "0x26C705C")]
		public _003CSetHotFixDownload_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6010F84")]
		[Address(RVA = "0x26C706C", Offset = "0x26C706C", VA = "0x26C706C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4010293")]
	[FieldOffset(Offset = "0x28")]
	private UINewVaultHeadPreviewView m_View;

	[Token(Token = "0x4010294")]
	[FieldOffset(Offset = "0x2C")]
	private UIBaseProfileInfoController m_ProfilePreview;

	[Token(Token = "0x4010295")]
	[FieldOffset(Offset = "0x30")]
	private UIModelCollection m_modelCollection;

	[Token(Token = "0x4010296")]
	[FieldOffset(Offset = "0x34")]
	private UINewDownloadInfoController m_DownloadCtrl;

	[Token(Token = "0x4010297")]
	[FieldOffset(Offset = "0x38")]
	private uint m_HeadID;

	[Token(Token = "0x4010298")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_PinID;

	[Token(Token = "0x4010299")]
	[FieldOffset(Offset = "0x40")]
	private uint m_BannerID;

	[Token(Token = "0x401029A")]
	[FieldOffset(Offset = "0x44")]
	private bool m_NeedDownload;

	[Token(Token = "0x401029B")]
	[FieldOffset(Offset = "0x48")]
	private UIModelNewVault.eSecondTab m_SecondTab;

	[Token(Token = "0x6010F76")]
	[Address(RVA = "0x26C5738", Offset = "0x26C5738", VA = "0x26C5738")]
	public UINewVaultHeadPreviewController()
	{
	}

	[Token(Token = "0x6010F77")]
	[Address(RVA = "0x26C57BC", Offset = "0x26C57BC", VA = "0x26C57BC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010F78")]
	[Address(RVA = "0x26C5864", Offset = "0x26C5864", VA = "0x26C5864")]
	public UIBaseProfileInfoController GetBaseProfileInfoController()
	{
		return null;
	}

	[Token(Token = "0x6010F79")]
	[Address(RVA = "0x26C58BC", Offset = "0x26C58BC", VA = "0x26C58BC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010F7A")]
	[Address(RVA = "0x26C5E10", Offset = "0x26C5E10", VA = "0x26C5E10")]
	public void SetProfilePreviewPos(UIModelNewVault.eSecondTab secondTab)
	{
	}

	[Token(Token = "0x6010F7B")]
	[Address(RVA = "0x26C5B4C", Offset = "0x26C5B4C", VA = "0x26C5B4C")]
	private void UpdatePreview()
	{
	}

	[Token(Token = "0x6010F7C")]
	[Address(RVA = "0x26C60C0", Offset = "0x26C60C0", VA = "0x26C60C0")]
	public void UpdataHeadPic(uint headID)
	{
	}

	[Token(Token = "0x6010F7D")]
	[Address(RVA = "0x26C61F4", Offset = "0x26C61F4", VA = "0x26C61F4")]
	public void UpdateBriefBanner(uint bannerId)
	{
	}

	[Token(Token = "0x6010F7E")]
	[Address(RVA = "0x26C64B8", Offset = "0x26C64B8", VA = "0x26C64B8")]
	public void UpdatePin(uint pinId)
	{
	}

	[Token(Token = "0x6010F7F")]
	[Address(RVA = "0x26C6EA0", Offset = "0x26C6EA0", VA = "0x26C6EA0", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010F80")]
	[Address(RVA = "0x26C6FA4", Offset = "0x26C6FA4", VA = "0x26C6FA4", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010F81")]
	[Address(RVA = "0x26C678C", Offset = "0x26C678C", VA = "0x26C678C")]
	public void SetHotFixDownload()
	{
	}

	[Token(Token = "0x6010F82")]
	[Address(RVA = "0x26C7064", Offset = "0x26C7064", VA = "0x26C7064")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
