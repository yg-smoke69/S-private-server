using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002988")]
public class UIManualMapEvtController : UIManualContentBaseController
{
	[Token(Token = "0x2002989")]
	public enum LocationType
	{
		[Token(Token = "0x400FFCE")]
		NONE,
		[Token(Token = "0x400FFCF")]
		LEFT,
		[Token(Token = "0x400FFD0")]
		RIGHT
	}

	[Token(Token = "0x200298A")]
	private sealed class _003CDoRefreshView_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FFD1")]
		[FieldOffset(Offset = "0x8")]
		internal int pageID;

		[Token(Token = "0x6010AD1")]
		[Address(RVA = "0x2C3AA48", Offset = "0x2C3AA48", VA = "0x2C3AA48")]
		public _003CDoRefreshView_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6010AD2")]
		[Address(RVA = "0x2C3B470", Offset = "0x2C3B470", VA = "0x2C3B470")]
		internal bool _003C_003Em__0(ManualInMapData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400FFC7")]
	[FieldOffset(Offset = "0x3C")]
	private UIManualMapEvtView m_View;

	[Token(Token = "0x400FFC8")]
	[FieldOffset(Offset = "0x40")]
	private UIManualMapEventData m_Data;

	[Token(Token = "0x400FFC9")]
	[FieldOffset(Offset = "0x44")]
	private UIManualMapEvtItemController m_LeftCtrl;

	[Token(Token = "0x400FFCA")]
	[FieldOffset(Offset = "0x48")]
	private UIManualMapEvtItemController m_RightCtrl;

	[Token(Token = "0x400FFCB")]
	[FieldOffset(Offset = "0x4C")]
	private GameObject m_LeftArrowTips;

	[Token(Token = "0x400FFCC")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_RightArrowTips;

	[Token(Token = "0x6010AC0")]
	[Address(RVA = "0x2C397E8", Offset = "0x2C397E8", VA = "0x2C397E8")]
	public UIManualMapEvtController()
	{
	}

	[Token(Token = "0x6010AC1")]
	[Address(RVA = "0x2C397F0", Offset = "0x2C397F0", VA = "0x2C397F0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010AC2")]
	[Address(RVA = "0x2C39894", Offset = "0x2C39894", VA = "0x2C39894", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010AC3")]
	[Address(RVA = "0x2C39DBC", Offset = "0x2C39DBC", VA = "0x2C39DBC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010AC4")]
	[Address(RVA = "0x2C39E20", Offset = "0x2C39E20", VA = "0x2C39E20", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010AC5")]
	[Address(RVA = "0x2C39E84", Offset = "0x2C39E84", VA = "0x2C39E84", Slot = "31")]
	public override void SetData(UIManualDataBase data)
	{
	}

	[Token(Token = "0x6010AC6")]
	[Address(RVA = "0x2C39F7C", Offset = "0x2C39F7C", VA = "0x2C39F7C", Slot = "33")]
	public override void RefreshView()
	{
	}

	[Token(Token = "0x6010AC7")]
	[Address(RVA = "0x2C3A87C", Offset = "0x2C3A87C", VA = "0x2C3A87C", Slot = "34")]
	protected override int GetMaxPage()
	{
		return default(int);
	}

	[Token(Token = "0x6010AC8")]
	[Address(RVA = "0x2C39B7C", Offset = "0x2C39B7C", VA = "0x2C39B7C")]
	private void InitEvtItemCtrl()
	{
	}

	[Token(Token = "0x6010AC9")]
	[Address(RVA = "0x2C39FEC", Offset = "0x2C39FEC", VA = "0x2C39FEC")]
	private void DoRefreshView(int pageID)
	{
	}

	[Token(Token = "0x6010ACA")]
	[Address(RVA = "0x2C3B3A0", Offset = "0x2C3B3A0", VA = "0x2C3B3A0")]
	public void OnClickMore(ManualInMapData data)
	{
	}

	[Token(Token = "0x6010ACB")]
	[Address(RVA = "0x2C3B440", Offset = "0x2C3B440", VA = "0x2C3B440")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010ACC")]
	[Address(RVA = "0x2C3B448", Offset = "0x2C3B448", VA = "0x2C3B448")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010ACD")]
	[Address(RVA = "0x2C3B450", Offset = "0x2C3B450", VA = "0x2C3B450")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6010ACE")]
	[Address(RVA = "0x2C3B458", Offset = "0x2C3B458", VA = "0x2C3B458")]
	public void _003C_003EiFixBaseProxy_SetData(UIManualDataBase P0)
	{
	}

	[Token(Token = "0x6010ACF")]
	[Address(RVA = "0x2C3B460", Offset = "0x2C3B460", VA = "0x2C3B460")]
	public void _003C_003EiFixBaseProxy_RefreshView()
	{
	}

	[Token(Token = "0x6010AD0")]
	[Address(RVA = "0x2C3B468", Offset = "0x2C3B468", VA = "0x2C3B468")]
	public int _003C_003EiFixBaseProxy_GetMaxPage()
	{
		return default(int);
	}
}
