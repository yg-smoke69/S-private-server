using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200298E")]
public class UIManualMapSupplyController : UIManualContentBaseController
{
	[Token(Token = "0x200298F")]
	private sealed class _003CDoRefreshView_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FFE4")]
		[FieldOffset(Offset = "0x8")]
		internal int pageID;

		[Token(Token = "0x6010B03")]
		[Address(RVA = "0x2C3F73C", Offset = "0x2C3F73C", VA = "0x2C3F73C")]
		public _003CDoRefreshView_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6010B04")]
		[Address(RVA = "0x2C3FF90", Offset = "0x2C3FF90", VA = "0x2C3FF90")]
		internal bool _003C_003Em__0(ManualInMapData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002990")]
	private sealed class _003CCheckIsUnlock_003Ec__AnonStorey1
	{
		[Token(Token = "0x400FFE5")]
		[FieldOffset(Offset = "0x8")]
		internal uint evtId;

		[Token(Token = "0x6010B05")]
		[Address(RVA = "0x2C3FECC", Offset = "0x2C3FECC", VA = "0x2C3FECC")]
		public _003CCheckIsUnlock_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6010B06")]
		[Address(RVA = "0x2C3FF7C", Offset = "0x2C3FF7C", VA = "0x2C3FF7C")]
		internal bool _003C_003Em__0(uint e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400FFDC")]
	[FieldOffset(Offset = "0x3C")]
	private UIManualMapSupplyView m_View;

	[Token(Token = "0x400FFDD")]
	[FieldOffset(Offset = "0x40")]
	private UIManualMapSupplyData m_Data;

	[Token(Token = "0x400FFDE")]
	[FieldOffset(Offset = "0x44")]
	private ManualInMapData m_CurSelectedData;

	[Token(Token = "0x400FFDF")]
	[FieldOffset(Offset = "0x48")]
	private List<GameObject> m_SupplyList;

	[Token(Token = "0x400FFE0")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIManualMapSupplyItemController> m_ItmCtlList;

	[Token(Token = "0x400FFE1")]
	[FieldOffset(Offset = "0x50")]
	private UIScrollView m_LabelScrollView;

	[Token(Token = "0x400FFE2")]
	[FieldOffset(Offset = "0x54")]
	private GameObject m_LeftArrowTips;

	[Token(Token = "0x400FFE3")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_RightArrowTips;

	[Token(Token = "0x6010AEB")]
	[Address(RVA = "0x2C3CFB8", Offset = "0x2C3CFB8", VA = "0x2C3CFB8")]
	public UIManualMapSupplyController()
	{
	}

	[Token(Token = "0x6010AEC")]
	[Address(RVA = "0x2C3D078", Offset = "0x2C3D078", VA = "0x2C3D078")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010AED")]
	[Address(RVA = "0x2C3D11C", Offset = "0x2C3D11C", VA = "0x2C3D11C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010AEE")]
	[Address(RVA = "0x2C3DADC", Offset = "0x2C3DADC", VA = "0x2C3DADC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010AEF")]
	[Address(RVA = "0x2C3DB40", Offset = "0x2C3DB40", VA = "0x2C3DB40", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010AF0")]
	[Address(RVA = "0x2C3DBA4", Offset = "0x2C3DBA4", VA = "0x2C3DBA4", Slot = "31")]
	public override void SetData(UIManualDataBase data)
	{
	}

	[Token(Token = "0x6010AF1")]
	[Address(RVA = "0x2C3DC9C", Offset = "0x2C3DC9C", VA = "0x2C3DC9C", Slot = "33")]
	public override void RefreshView()
	{
	}

	[Token(Token = "0x6010AF2")]
	[Address(RVA = "0x2C3E2AC", Offset = "0x2C3E2AC", VA = "0x2C3E2AC", Slot = "34")]
	protected override int GetMaxPage()
	{
		return default(int);
	}

	[Token(Token = "0x6010AF3")]
	[Address(RVA = "0x2C3E478", Offset = "0x2C3E478", VA = "0x2C3E478")]
	public void RefreshRightContent(ManualInMapData data)
	{
	}

	[Token(Token = "0x6010AF4")]
	[Address(RVA = "0x2C3EDE0", Offset = "0x2C3EDE0", VA = "0x2C3EDE0")]
	public void RefreshLeftSelectState()
	{
	}

	[Token(Token = "0x6010AF5")]
	[Address(RVA = "0x2C3E9D8", Offset = "0x2C3E9D8", VA = "0x2C3E9D8")]
	private void SetIcon(UISprite icon, ManualInMapData data)
	{
	}

	[Token(Token = "0x6010AF6")]
	[Address(RVA = "0x2C3D548", Offset = "0x2C3D548", VA = "0x2C3D548")]
	private void InitSupplyList()
	{
	}

	[Token(Token = "0x6010AF7")]
	[Address(RVA = "0x2C3F570", Offset = "0x2C3F570", VA = "0x2C3F570")]
	private void RestSupplyList()
	{
	}

	[Token(Token = "0x6010AF8")]
	[Address(RVA = "0x2C3D9CC", Offset = "0x2C3D9CC", VA = "0x2C3D9CC")]
	private void ShowRightContent(bool v)
	{
	}

	[Token(Token = "0x6010AF9")]
	[Address(RVA = "0x2C3DD0C", Offset = "0x2C3DD0C", VA = "0x2C3DD0C")]
	private void DoRefreshView(int pageID)
	{
	}

	[Token(Token = "0x6010AFA")]
	[Address(RVA = "0x2C3F744", Offset = "0x2C3F744", VA = "0x2C3F744")]
	private void RefreshLeftContent(List<ManualInMapData> data)
	{
	}

	[Token(Token = "0x6010AFB")]
	[Address(RVA = "0x2C3EBFC", Offset = "0x2C3EBFC", VA = "0x2C3EBFC")]
	private bool CheckIsUnlock(uint evtId)
	{
		return default(bool);
	}

	[Token(Token = "0x6010AFC")]
	[Address(RVA = "0x2C3FED4", Offset = "0x2C3FED4", VA = "0x2C3FED4")]
	public void OnClickMore()
	{
	}

	[Token(Token = "0x6010AFD")]
	[Address(RVA = "0x2C3FF4C", Offset = "0x2C3FF4C", VA = "0x2C3FF4C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010AFE")]
	[Address(RVA = "0x2C3FF54", Offset = "0x2C3FF54", VA = "0x2C3FF54")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010AFF")]
	[Address(RVA = "0x2C3FF5C", Offset = "0x2C3FF5C", VA = "0x2C3FF5C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6010B00")]
	[Address(RVA = "0x2C3FF64", Offset = "0x2C3FF64", VA = "0x2C3FF64")]
	public void _003C_003EiFixBaseProxy_SetData(UIManualDataBase P0)
	{
	}

	[Token(Token = "0x6010B01")]
	[Address(RVA = "0x2C3FF6C", Offset = "0x2C3FF6C", VA = "0x2C3FF6C")]
	public void _003C_003EiFixBaseProxy_RefreshView()
	{
	}

	[Token(Token = "0x6010B02")]
	[Address(RVA = "0x2C3FF74", Offset = "0x2C3FF74", VA = "0x2C3FF74")]
	public int _003C_003EiFixBaseProxy_GetMaxPage()
	{
		return default(int);
	}
}
