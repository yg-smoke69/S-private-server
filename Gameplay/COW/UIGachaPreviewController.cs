using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200266C")]
public class UIGachaPreviewController : UIBaseController, _Attribute
{
	[Token(Token = "0x200266D")]
	public enum Type
	{
		[Token(Token = "0x400ED47")]
		NORMAL,
		[Token(Token = "0x400ED48")]
		LUCKYBAG
	}

	[Token(Token = "0x200266E")]
	private sealed class _003CHighLightItemByID_003Ec__AnonStorey0
	{
		[Token(Token = "0x400ED49")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemID;

		[Token(Token = "0x600E61A")]
		[Address(RVA = "0x2A21F7C", Offset = "0x2A21F7C", VA = "0x2A21F7C")]
		public _003CHighLightItemByID_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E61B")]
		[Address(RVA = "0x2A21F9C", Offset = "0x2A21F9C", VA = "0x2A21F9C")]
		internal bool _003C_003Em__0(GachaShowItem item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400ED40")]
	[FieldOffset(Offset = "0x28")]
	private float m_ScorllViewOffest;

	[Token(Token = "0x400ED41")]
	[FieldOffset(Offset = "0x2C")]
	private UIGachaPreviewView m_View;

	[Token(Token = "0x400ED42")]
	[FieldOffset(Offset = "0x30")]
	protected UIModelGacha m_ModelGacha;

	[Token(Token = "0x400ED43")]
	[FieldOffset(Offset = "0x34")]
	protected uint m_GachaId;

	[Token(Token = "0x400ED44")]
	[FieldOffset(Offset = "0x38")]
	private List<GachaShowItem> m_Infolist;

	[Token(Token = "0x400ED45")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_refreshFinish;

	[Token(Token = "0x600E60A")]
	[Address(RVA = "0x2A202FC", Offset = "0x2A202FC", VA = "0x2A202FC")]
	public UIGachaPreviewController()
	{
	}

	[Token(Token = "0x600E60B")]
	[Address(RVA = "0x2A2038C", Offset = "0x2A2038C", VA = "0x2A2038C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E60C")]
	[Address(RVA = "0x2A20430", Offset = "0x2A20430", VA = "0x2A20430", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E60D")]
	[Address(RVA = "0x2A207A8", Offset = "0x2A207A8", VA = "0x2A207A8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E60E")]
	[Address(RVA = "0x2A208C0", Offset = "0x2A208C0", VA = "0x2A208C0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E60F")]
	[Address(RVA = "0x2A20A5C", Offset = "0x2A20A5C", VA = "0x2A20A5C", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E610")]
	[Address(RVA = "0x2A20B54", Offset = "0x2A20B54", VA = "0x2A20B54", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600E611")]
	[Address(RVA = "0x2A20BB0", Offset = "0x2A20BB0", VA = "0x2A20BB0")]
	protected void ClosePanel(object[] param)
	{
	}

	[Token(Token = "0x600E612")]
	[Address(RVA = "0x2A20C1C", Offset = "0x2A20C1C", VA = "0x2A20C1C", Slot = "33")]
	public virtual void RefreshView(uint gachaId)
	{
	}

	[Token(Token = "0x600E613")]
	[Address(RVA = "0x2A21424", Offset = "0x2A21424", VA = "0x2A21424")]
	private void OnBtnProbabilityClick()
	{
	}

	[Token(Token = "0x600E614")]
	[Address(RVA = "0x2A21550", Offset = "0x2A21550", VA = "0x2A21550")]
	private void ShowRareProbabilityTips(object[] param)
	{
	}

	[Token(Token = "0x600E615")]
	[Address(RVA = "0x2A21BD0", Offset = "0x2A21BD0", VA = "0x2A21BD0", Slot = "34")]
	public virtual void HighLightItemByIndex(int index, bool needScroll = true)
	{
	}

	[Token(Token = "0x600E616")]
	[Address(RVA = "0x2A21D98", Offset = "0x2A21D98", VA = "0x2A21D98", Slot = "35")]
	public virtual void HighLightItemByID(uint itemID, bool needScroll = true)
	{
	}

	[Token(Token = "0x600E617")]
	[Address(RVA = "0x2A21F84", Offset = "0x2A21F84", VA = "0x2A21F84")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E618")]
	[Address(RVA = "0x2A21F8C", Offset = "0x2A21F8C", VA = "0x2A21F8C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E619")]
	[Address(RVA = "0x2A21F94", Offset = "0x2A21F94", VA = "0x2A21F94")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
