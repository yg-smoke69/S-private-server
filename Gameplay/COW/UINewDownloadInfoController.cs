using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029E9")]
public class UINewDownloadInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x40101B7")]
	[FieldOffset(Offset = "0x28")]
	private UINewDownloadInfoView m_View;

	[Token(Token = "0x40101B8")]
	[FieldOffset(Offset = "0x2C")]
	private Action m_Callback1;

	[Token(Token = "0x40101B9")]
	[FieldOffset(Offset = "0x30")]
	private Action m_Callback2;

	[Token(Token = "0x40101BA")]
	[FieldOffset(Offset = "0x34")]
	private DownloadShowStyle m_style;

	[Token(Token = "0x40101BB")]
	[FieldOffset(Offset = "0x38")]
	private DownloadShowState m_DownloadState;

	[Token(Token = "0x40101BC")]
	[FieldOffset(Offset = "0x3C")]
	public Action DownloadStateChangeCallback;

	[Token(Token = "0x40101BD")]
	[FieldOffset(Offset = "0x40")]
	private List<ResourceID> m_downloadlist;

	[Token(Token = "0x40101BE")]
	[FieldOffset(Offset = "0x44")]
	private bool m_NeedShowAll;

	[Token(Token = "0x40101BF")]
	[FieldOffset(Offset = "0x45")]
	private bool m_NeedShowCommon;

	[Token(Token = "0x40101C0")]
	[FieldOffset(Offset = "0x48")]
	private ResDownloadType m_DownloadType;

	[Token(Token = "0x40101C1")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_OnlyShowIcon;

	[Token(Token = "0x40101C2")]
	[FieldOffset(Offset = "0x50")]
	private List<ResVersionInfo.FileInfo> m_NeedDownloadFileInfoList;

	[Token(Token = "0x40101C3")]
	[FieldOffset(Offset = "0x54")]
	private bool m_HasBranchGroup;

	[Token(Token = "0x40101C4")]
	[FieldOffset(Offset = "0x58")]
	private uint m_itemid;

	[Token(Token = "0x40101C5")]
	[FieldOffset(Offset = "0x5C")]
	private DownloadInfoSpecific m_downloadinfo;

	[Token(Token = "0x40101C6")]
	[FieldOffset(Offset = "0x60")]
	private bool m_donotcheck;

	[Token(Token = "0x40101C7")]
	[FieldOffset(Offset = "0x61")]
	private bool m_FirstEnterDownload;

	[Token(Token = "0x40101C8")]
	[FieldOffset(Offset = "0x64")]
	private int m_FirstFrame;

	[Token(Token = "0x40101C9")]
	[FieldOffset(Offset = "0x68")]
	private int m_DelayShowFrame;

	[Token(Token = "0x40101CA")]
	[FieldOffset(Offset = "0x6C")]
	private float m_LastProgress;

	[Token(Token = "0x6010DEB")]
	[Address(RVA = "0x279F2C4", Offset = "0x279F2C4", VA = "0x279F2C4")]
	public UINewDownloadInfoController()
	{
	}

	[Token(Token = "0x6010DEC")]
	[Address(RVA = "0x279F3B0", Offset = "0x279F3B0", VA = "0x279F3B0")]
	public void RefreshItemId(uint id, DownloadInfoSpecific downloadInfo)
	{
	}

	[Token(Token = "0x6010DED")]
	[Address(RVA = "0x279F430", Offset = "0x279F430", VA = "0x279F430")]
	public DownloadInfoSpecific GetDownloadInfo()
	{
		return null;
	}

	[Token(Token = "0x6010DEE")]
	[Address(RVA = "0x279F488", Offset = "0x279F488", VA = "0x279F488")]
	public uint GetItemId()
	{
		return default(uint);
	}

	[Token(Token = "0x6010DEF")]
	[Address(RVA = "0x279F4E0", Offset = "0x279F4E0", VA = "0x279F4E0")]
	public void RefreshMainGroup(bool flag)
	{
	}

	[Token(Token = "0x6010DF0")]
	[Address(RVA = "0x279F66C", Offset = "0x279F66C", VA = "0x279F66C")]
	public void RefreshBranchGroup(bool flag)
	{
	}

	[Token(Token = "0x6010DF1")]
	[Address(RVA = "0x279F6CC", Offset = "0x279F6CC", VA = "0x279F6CC")]
	public bool GetMainGroupVisble()
	{
		return default(bool);
	}

	[Token(Token = "0x6010DF2")]
	[Address(RVA = "0x279F724", Offset = "0x279F724", VA = "0x279F724")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010DF3")]
	[Address(RVA = "0x279F7CC", Offset = "0x279F7CC", VA = "0x279F7CC", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010DF4")]
	[Address(RVA = "0x279F828", Offset = "0x279F828", VA = "0x279F828")]
	public DownloadShowState GetDownloadState()
	{
		return default(DownloadShowState);
	}

	[Token(Token = "0x6010DF5")]
	[Address(RVA = "0x279F880", Offset = "0x279F880", VA = "0x279F880")]
	public List<ResourceID> GetDownloadList()
	{
		return null;
	}

	[Token(Token = "0x6010DF6")]
	[Address(RVA = "0x279F8D8", Offset = "0x279F8D8", VA = "0x279F8D8", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010DF7")]
	[Address(RVA = "0x279F978", Offset = "0x279F978", VA = "0x279F978", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010DF8")]
	[Address(RVA = "0x279FA0C", Offset = "0x279FA0C", VA = "0x279FA0C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010DF9")]
	[Address(RVA = "0x279FFB0", Offset = "0x279FFB0", VA = "0x279FFB0")]
	private void OnDownloadALL()
	{
	}

	[Token(Token = "0x6010DFA")]
	[Address(RVA = "0x27A01FC", Offset = "0x27A01FC", VA = "0x27A01FC")]
	private bool CheckHasFileDownload()
	{
		return default(bool);
	}

	[Token(Token = "0x6010DFB")]
	[Address(RVA = "0x27A04D4", Offset = "0x27A04D4", VA = "0x27A04D4")]
	private bool CheckHasFilePending()
	{
		return default(bool);
	}

	[Token(Token = "0x6010DFC")]
	[Address(RVA = "0x27A079C", Offset = "0x27A079C", VA = "0x27A079C")]
	private bool CheckAllFileFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x6010DFD")]
	[Address(RVA = "0x27A0A68", Offset = "0x27A0A68", VA = "0x27A0A68")]
	private void UpdateDownloadState()
	{
	}

	[Token(Token = "0x6010DFE")]
	[Address(RVA = "0x279F600", Offset = "0x279F600", VA = "0x279F600")]
	private void OnDownloadStateChange()
	{
	}

	[Token(Token = "0x6010DFF")]
	[Address(RVA = "0x27A0AFC", Offset = "0x27A0AFC", VA = "0x27A0AFC")]
	private void UpdateUIDownloadStyle1()
	{
	}

	[Token(Token = "0x6010E00")]
	[Address(RVA = "0x27A1478", Offset = "0x27A1478", VA = "0x27A1478")]
	private void UpdateUIDownloadStyle2()
	{
	}

	[Token(Token = "0x6010E01")]
	[Address(RVA = "0x27A1B88", Offset = "0x27A1B88", VA = "0x27A1B88")]
	public void HideHotFixDownloadTxt4()
	{
	}

	[Token(Token = "0x6010E02")]
	[Address(RVA = "0x27A1C94", Offset = "0x27A1C94", VA = "0x27A1C94")]
	private void UpdateUIDownloadStyle4()
	{
	}

	[Token(Token = "0x6010E03")]
	[Address(RVA = "0x27A2204", Offset = "0x27A2204", VA = "0x27A2204")]
	private void UpdateUIDownloadStyle5()
	{
	}

	[Token(Token = "0x6010E04")]
	[Address(RVA = "0x27A2588", Offset = "0x27A2588", VA = "0x27A2588")]
	private void UpdateUIDownloadStyle3()
	{
	}

	[Token(Token = "0x6010E05")]
	[Address(RVA = "0x27A2E04", Offset = "0x27A2E04", VA = "0x27A2E04")]
	private void OnDownload()
	{
	}

	[Token(Token = "0x6010E06")]
	[Address(RVA = "0x27A3050", Offset = "0x27A3050", VA = "0x27A3050", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010E07")]
	[Address(RVA = "0x27A318C", Offset = "0x27A318C", VA = "0x27A318C")]
	public void SetHasBranchInfo(bool flag)
	{
	}

	[Token(Token = "0x6010E08")]
	[Address(RVA = "0x27A31EC", Offset = "0x27A31EC", VA = "0x27A31EC")]
	public void RefreshAllDownloadDataInfo(DownloadShowAllInfo info)
	{
	}

	[Token(Token = "0x6010E09")]
	[Address(RVA = "0x27A341C", Offset = "0x27A341C", VA = "0x27A341C")]
	public void RefreshCommonDownloadDataInfo(DownloadShowInfo info)
	{
	}

	[Token(Token = "0x6010E0A")]
	[Address(RVA = "0x27A3BC8", Offset = "0x27A3BC8", VA = "0x27A3BC8")]
	public void SetStyleBoxSize(int sizeX, int sizeY, int depth = 0)
	{
	}

	[Token(Token = "0x6010E0B")]
	[Address(RVA = "0x27A41C4", Offset = "0x27A41C4", VA = "0x27A41C4")]
	public void SetBoxColliderRegion(Vector3 center, Vector3 size)
	{
	}

	[Token(Token = "0x6010E0C")]
	[Address(RVA = "0x27A44A8", Offset = "0x27A44A8", VA = "0x27A44A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6010E0D")]
	[Address(RVA = "0x27A45AC", Offset = "0x27A45AC", VA = "0x27A45AC")]
	public void Download()
	{
	}

	[Token(Token = "0x6010E0E")]
	[Address(RVA = "0x27A460C", Offset = "0x27A460C", VA = "0x27A460C")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010E0F")]
	[Address(RVA = "0x27A4614", Offset = "0x27A4614", VA = "0x27A4614")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010E10")]
	[Address(RVA = "0x27A461C", Offset = "0x27A461C", VA = "0x27A461C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
