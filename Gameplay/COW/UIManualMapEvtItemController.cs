using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200298B")]
public class UIManualMapEvtItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x200298C")]
	private sealed class _003CCheckIsUnlock_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FFD8")]
		[FieldOffset(Offset = "0x8")]
		internal uint evtId;

		[Token(Token = "0x6010AE3")]
		[Address(RVA = "0x2C3BEAC", Offset = "0x2C3BEAC", VA = "0x2C3BEAC")]
		public _003CCheckIsUnlock_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6010AE4")]
		[Address(RVA = "0x2C3C394", Offset = "0x2C3C394", VA = "0x2C3C394")]
		internal bool _003C_003Em__0(uint e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400FFD2")]
	[FieldOffset(Offset = "0x28")]
	private UIManualMapEvtItemView m_View;

	[Token(Token = "0x400FFD3")]
	[FieldOffset(Offset = "0x2C")]
	private ManualInMapData m_Data;

	[Token(Token = "0x400FFD4")]
	[FieldOffset(Offset = "0x30")]
	private float m_Scale;

	[Token(Token = "0x400FFD5")]
	[FieldOffset(Offset = "0x34")]
	private uint m_ShowDelayCallID;

	[Token(Token = "0x400FFD6")]
	[FieldOffset(Offset = "0x38")]
	private TweenAlpha m_TweenAlpha;

	[Token(Token = "0x400FFD7")]
	[FieldOffset(Offset = "0x3C")]
	private UIScrollView m_LabelScrollView;

	[Token(Token = "0x6010AD3")]
	[Address(RVA = "0x2C3B4B0", Offset = "0x2C3B4B0", VA = "0x2C3B4B0")]
	public UIManualMapEvtItemController()
	{
	}

	[Token(Token = "0x6010AD4")]
	[Address(RVA = "0x2C3B534", Offset = "0x2C3B534", VA = "0x2C3B534")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010AD5")]
	[Address(RVA = "0x2C3B5D8", Offset = "0x2C3B5D8", VA = "0x2C3B5D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010AD6")]
	[Address(RVA = "0x2C3B8A4", Offset = "0x2C3B8A4", VA = "0x2C3B8A4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010AD7")]
	[Address(RVA = "0x2C3B908", Offset = "0x2C3B908", VA = "0x2C3B908", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010AD8")]
	[Address(RVA = "0x2C3AA50", Offset = "0x2C3AA50", VA = "0x2C3AA50")]
	public void SetData(ManualInMapData data, float scale = 1f)
	{
	}

	[Token(Token = "0x6010AD9")]
	[Address(RVA = "0x2C3AAD4", Offset = "0x2C3AAD4", VA = "0x2C3AAD4")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x6010ADA")]
	[Address(RVA = "0x2C3BA8C", Offset = "0x2C3BA8C", VA = "0x2C3BA8C")]
	private void SetIcon(UISprite icon, ManualInMapData data)
	{
	}

	[Token(Token = "0x6010ADB")]
	[Address(RVA = "0x2C3BCB0", Offset = "0x2C3BCB0", VA = "0x2C3BCB0")]
	private bool CheckIsUnlock(uint evtId)
	{
		return default(bool);
	}

	[Token(Token = "0x6010ADC")]
	[Address(RVA = "0x2C3BEB4", Offset = "0x2C3BEB4", VA = "0x2C3BEB4")]
	private void OnClickMore()
	{
	}

	[Token(Token = "0x6010ADD")]
	[Address(RVA = "0x2C3C00C", Offset = "0x2C3C00C", VA = "0x2C3C00C", Slot = "31")]
	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x6010ADE")]
	[Address(RVA = "0x2C3C1E4", Offset = "0x2C3C1E4", VA = "0x2C3C1E4")]
	public void OnTweenFinish()
	{
	}

	[Token(Token = "0x6010ADF")]
	[Address(RVA = "0x2C3C274", Offset = "0x2C3C274", VA = "0x2C3C274")]
	private void _003CRefreshView_003Em__0()
	{
	}

	[Token(Token = "0x6010AE0")]
	[Address(RVA = "0x2C3C37C", Offset = "0x2C3C37C", VA = "0x2C3C37C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010AE1")]
	[Address(RVA = "0x2C3C384", Offset = "0x2C3C384", VA = "0x2C3C384")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010AE2")]
	[Address(RVA = "0x2C3C38C", Offset = "0x2C3C38C", VA = "0x2C3C38C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
