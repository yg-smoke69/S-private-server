using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026AA")]
public class UIGameModeMapPickItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x20026AB")]
	private sealed class _003CRefreshDownloadState_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EEAA")]
		[FieldOffset(Offset = "0x8")]
		internal List<ResourceID> listNeedDownloadMapRes;

		[Token(Token = "0x400EEAB")]
		[FieldOffset(Offset = "0xC")]
		internal UIGameModeMapPickItemController _0024this;

		[Token(Token = "0x600E8FD")]
		[Address(RVA = "0x2189018", Offset = "0x2189018", VA = "0x2189018")]
		public _003CRefreshDownloadState_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E8FE")]
		[Address(RVA = "0x21893C8", Offset = "0x21893C8", VA = "0x21893C8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400EEA5")]
	[FieldOffset(Offset = "0x28")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x400EEA6")]
	[FieldOffset(Offset = "0x2C")]
	private UIGameModeMapPickItemView m_View;

	[Token(Token = "0x400EEA7")]
	[FieldOffset(Offset = "0x30")]
	private bool m_Selected;

	[Token(Token = "0x400EEA8")]
	[FieldOffset(Offset = "0x34")]
	public MapModeData MapData;

	[Token(Token = "0x400EEA9")]
	[FieldOffset(Offset = "0x38")]
	private UINewDownloadInfoController m_DownloadCtrl;

	[Token(Token = "0x600E8EB")]
	[Address(RVA = "0x21877AC", Offset = "0x21877AC", VA = "0x21877AC")]
	public UIGameModeMapPickItemController()
	{
	}

	[Token(Token = "0x600E8EC")]
	[Address(RVA = "0x2187838", Offset = "0x2187838", VA = "0x2187838")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E8ED")]
	[Address(RVA = "0x21878E0", Offset = "0x21878E0", VA = "0x21878E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E8EE")]
	[Address(RVA = "0x2187BEC", Offset = "0x2187BEC", VA = "0x2187BEC", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E8EF")]
	[Address(RVA = "0x2187C80", Offset = "0x2187C80", VA = "0x2187C80", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E8F0")]
	[Address(RVA = "0x2187F60", Offset = "0x2187F60", VA = "0x2187F60")]
	public void SetData(MapModeData data)
	{
	}

	[Token(Token = "0x600E8F1")]
	[Address(RVA = "0x218825C", Offset = "0x218825C", VA = "0x218825C")]
	public void TrySelect()
	{
	}

	[Token(Token = "0x600E8F2")]
	[Address(RVA = "0x2188804", Offset = "0x2188804", VA = "0x2188804")]
	public void TryUnselect()
	{
	}

	[Token(Token = "0x600E8F3")]
	[Address(RVA = "0x2188108", Offset = "0x2188108", VA = "0x2188108")]
	public bool IsSelected()
	{
		return default(bool);
	}

	[Token(Token = "0x600E8F4")]
	[Address(RVA = "0x2187E04", Offset = "0x2187E04", VA = "0x2187E04")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600E8F5")]
	[Address(RVA = "0x2188870", Offset = "0x2188870", VA = "0x2188870")]
	private void RefreshDownloadState()
	{
	}

	[Token(Token = "0x600E8F6")]
	[Address(RVA = "0x2188DAC", Offset = "0x2188DAC", VA = "0x2188DAC")]
	private void RefreshLock()
	{
	}

	[Token(Token = "0x600E8F7")]
	[Address(RVA = "0x2188BB0", Offset = "0x2188BB0", VA = "0x2188BB0")]
	private void RefreshOpenTime()
	{
	}

	[Token(Token = "0x600E8F8")]
	[Address(RVA = "0x21882C8", Offset = "0x21882C8", VA = "0x21882C8")]
	private void OnClickBtnPick()
	{
	}

	[Token(Token = "0x600E8F9")]
	[Address(RVA = "0x2189020", Offset = "0x2189020", VA = "0x2189020")]
	private List<ResourceID> GetNeedDownloadMapResList()
	{
		return null;
	}

	[Token(Token = "0x600E8FA")]
	[Address(RVA = "0x218926C", Offset = "0x218926C", VA = "0x218926C")]
	public bool CanPick()
	{
		return default(bool);
	}

	[Token(Token = "0x600E8FB")]
	[Address(RVA = "0x2189374", Offset = "0x2189374", VA = "0x2189374")]
	private bool _003CIsSelected_003Em__0(MapModeData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E8FC")]
	[Address(RVA = "0x21893C0", Offset = "0x21893C0", VA = "0x21893C0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
