using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20020C1")]
public class UIDownloadCentreTabItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x400CD22")]
	[FieldOffset(Offset = "0x28")]
	private UIDownloadCentreTabItemView m_View;

	[Token(Token = "0x400CD23")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_CategoryTypeId;

	[Token(Token = "0x400CD24")]
	[FieldOffset(Offset = "0x30")]
	private PatchOptionalTypeManagerData m_ShowData;

	[Token(Token = "0x400CD25")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsSelected;

	[Token(Token = "0x400CD26")]
	[FieldOffset(Offset = "0x38")]
	private EDownloadContextState m_LastState;

	[Token(Token = "0x400CD27")]
	[FieldOffset(Offset = "0x3C")]
	private DownloadInfoGroup m_DownloadInfo;

	[Token(Token = "0x400CD28")]
	[FieldOffset(Offset = "0x40")]
	private UIModelOptionalDownload m_Model;

	[Token(Token = "0x600A932")]
	[Address(RVA = "0x2766F68", Offset = "0x2766F68", VA = "0x2766F68")]
	public UIDownloadCentreTabItemController()
	{
	}

	[Token(Token = "0x600A933")]
	[Address(RVA = "0x2766FEC", Offset = "0x2766FEC", VA = "0x2766FEC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A934")]
	[Address(RVA = "0x276744C", Offset = "0x276744C", VA = "0x276744C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A935")]
	[Address(RVA = "0x27648E8", Offset = "0x27648E8", VA = "0x27648E8")]
	public void SetViewData(uint typeId)
	{
	}

	[Token(Token = "0x600A936")]
	[Address(RVA = "0x276773C", Offset = "0x276773C", VA = "0x276773C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A937")]
	[Address(RVA = "0x27677A0", Offset = "0x27677A0", VA = "0x27677A0")]
	public void SetHighLightBGState(bool show)
	{
	}

	[Token(Token = "0x600A938")]
	[Address(RVA = "0x2767898", Offset = "0x2767898", VA = "0x2767898")]
	public void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600A939")]
	[Address(RVA = "0x2762FB4", Offset = "0x2762FB4", VA = "0x2762FB4")]
	public void OnTabItemSelect(uint selectedTypeId)
	{
	}

	[Token(Token = "0x600A93A")]
	[Address(RVA = "0x2767A40", Offset = "0x2767A40", VA = "0x2767A40")]
	private void Update()
	{
	}

	[Token(Token = "0x600A93B")]
	[Address(RVA = "0x27684AC", Offset = "0x27684AC", VA = "0x27684AC")]
	public void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600A93C")]
	[Address(RVA = "0x2768510", Offset = "0x2768510", VA = "0x2768510")]
	private void StartBtnClick()
	{
	}

	[Token(Token = "0x600A93D")]
	[Address(RVA = "0x27685B0", Offset = "0x27685B0", VA = "0x27685B0")]
	private void PauseBtnClick()
	{
	}

	[Token(Token = "0x600A93E")]
	[Address(RVA = "0x2768630", Offset = "0x2768630", VA = "0x2768630")]
	private void PendingBtnClick()
	{
	}

	[Token(Token = "0x600A93F")]
	[Address(RVA = "0x27686B0", Offset = "0x27686B0", VA = "0x27686B0")]
	private void InitBtnShowState()
	{
	}

	[Token(Token = "0x600A940")]
	[Address(RVA = "0x27674F4", Offset = "0x27674F4", VA = "0x27674F4")]
	private void ChangeBtnShowState()
	{
	}

	[Token(Token = "0x600A941")]
	[Address(RVA = "0x2767F0C", Offset = "0x2767F0C", VA = "0x2767F0C")]
	private void RefreshRewardBtnState()
	{
	}

	[Token(Token = "0x600A942")]
	[Address(RVA = "0x2768AE0", Offset = "0x2768AE0", VA = "0x2768AE0")]
	private void OnRewardBtnClick()
	{
	}

	[Token(Token = "0x600A943")]
	[Address(RVA = "0x27688CC", Offset = "0x27688CC", VA = "0x27688CC")]
	private void SetLastState(EDownloadContextState CurrentState)
	{
	}

	[Token(Token = "0x600A944")]
	[Address(RVA = "0x2768A40", Offset = "0x2768A40", VA = "0x2768A40")]
	private EActivity.State GetpriorityState(EActivity.State old_state, EActivity.State new_state)
	{
		return default(EActivity.State);
	}

	[Token(Token = "0x600A945")]
	[Address(RVA = "0x2768D08", Offset = "0x2768D08", VA = "0x2768D08", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A946")]
	[Address(RVA = "0x2768DD4", Offset = "0x2768DD4", VA = "0x2768DD4", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A947")]
	[Address(RVA = "0x2768E68", Offset = "0x2768E68", VA = "0x2768E68")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A948")]
	[Address(RVA = "0x2768E70", Offset = "0x2768E70", VA = "0x2768E70")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
