using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002976")]
public class UIManualGrownController : UIManualContentBaseController
{
	[Token(Token = "0x2002977")]
	private sealed class _003CDoRefreshView_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FF7D")]
		[FieldOffset(Offset = "0x8")]
		internal int ctrlIdx;

		[Token(Token = "0x6010A2C")]
		[Address(RVA = "0x2C245B8", Offset = "0x2C245B8", VA = "0x2C245B8")]
		public _003CDoRefreshView_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6010A2D")]
		[Address(RVA = "0x2C24894", Offset = "0x2C24894", VA = "0x2C24894")]
		internal bool _003C_003Em__0(LevelRewardData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400FF75")]
	[FieldOffset(Offset = "0x3C")]
	private UIManualGrownView m_View;

	[Token(Token = "0x400FF76")]
	[FieldOffset(Offset = "0x40")]
	private UIManualGrownData m_Data;

	[Token(Token = "0x400FF77")]
	[FieldOffset(Offset = "0x44")]
	private List<GameObject> m_PosList;

	[Token(Token = "0x400FF78")]
	[FieldOffset(Offset = "0x48")]
	private List<UIManualGrownItemGroupController> m_GroupCtrlList;

	[Token(Token = "0x400FF79")]
	[FieldOffset(Offset = "0x4C")]
	private List<GameObject> m_ProgressList;

	[Token(Token = "0x400FF7A")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_LeftArrowTips;

	[Token(Token = "0x400FF7B")]
	[FieldOffset(Offset = "0x54")]
	private GameObject m_RightArrowTips;

	[Token(Token = "0x400FF7C")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int m_GroupCnt;

	[Token(Token = "0x6010A1A")]
	[Address(RVA = "0x2C22DA0", Offset = "0x2C22DA0", VA = "0x2C22DA0")]
	public UIManualGrownController()
	{
	}

	[Token(Token = "0x6010A1B")]
	[Address(RVA = "0x2C22E78", Offset = "0x2C22E78", VA = "0x2C22E78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010A1C")]
	[Address(RVA = "0x2C22F1C", Offset = "0x2C22F1C", VA = "0x2C22F1C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010A1D")]
	[Address(RVA = "0x2C23A00", Offset = "0x2C23A00", VA = "0x2C23A00", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010A1E")]
	[Address(RVA = "0x2C23A64", Offset = "0x2C23A64", VA = "0x2C23A64", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010A1F")]
	[Address(RVA = "0x2C23AC8", Offset = "0x2C23AC8", VA = "0x2C23AC8", Slot = "31")]
	public override void SetData(UIManualDataBase data)
	{
	}

	[Token(Token = "0x6010A20")]
	[Address(RVA = "0x2C23BC0", Offset = "0x2C23BC0", VA = "0x2C23BC0", Slot = "33")]
	public override void RefreshView()
	{
	}

	[Token(Token = "0x6010A21")]
	[Address(RVA = "0x2C23C30", Offset = "0x2C23C30", VA = "0x2C23C30")]
	public void DoRefreshView(int pageID)
	{
	}

	[Token(Token = "0x6010A22")]
	[Address(RVA = "0x2C24744", Offset = "0x2C24744", VA = "0x2C24744", Slot = "34")]
	protected override int GetMaxPage()
	{
		return default(int);
	}

	[Token(Token = "0x6010A23")]
	[Address(RVA = "0x2C2320C", Offset = "0x2C2320C", VA = "0x2C2320C")]
	private void InitRewardGroup()
	{
	}

	[Token(Token = "0x6010A24")]
	[Address(RVA = "0x2C23718", Offset = "0x2C23718", VA = "0x2C23718")]
	private void InitProgress()
	{
	}

	[Token(Token = "0x6010A26")]
	[Address(RVA = "0x2C24864", Offset = "0x2C24864", VA = "0x2C24864")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010A27")]
	[Address(RVA = "0x2C2486C", Offset = "0x2C2486C", VA = "0x2C2486C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010A28")]
	[Address(RVA = "0x2C24874", Offset = "0x2C24874", VA = "0x2C24874")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6010A29")]
	[Address(RVA = "0x2C2487C", Offset = "0x2C2487C", VA = "0x2C2487C")]
	public void _003C_003EiFixBaseProxy_SetData(UIManualDataBase P0)
	{
	}

	[Token(Token = "0x6010A2A")]
	[Address(RVA = "0x2C24884", Offset = "0x2C24884", VA = "0x2C24884")]
	public void _003C_003EiFixBaseProxy_RefreshView()
	{
	}

	[Token(Token = "0x6010A2B")]
	[Address(RVA = "0x2C2488C", Offset = "0x2C2488C", VA = "0x2C2488C")]
	public int _003C_003EiFixBaseProxy_GetMaxPage()
	{
		return default(int);
	}
}
