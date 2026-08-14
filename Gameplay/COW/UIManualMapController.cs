using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002984")]
public class UIManualMapController : UIManualContentBaseController
{
	[Token(Token = "0x400FFAA")]
	[FieldOffset(Offset = "0x3C")]
	private UIManualMapView m_View;

	[Token(Token = "0x400FFAB")]
	[FieldOffset(Offset = "0x40")]
	private UIManualMapDebrisData m_DebrisData;

	[Token(Token = "0x400FFAC")]
	[FieldOffset(Offset = "0x44")]
	private UIManualMapDebrisController m_LeftCtrl;

	[Token(Token = "0x400FFAD")]
	[FieldOffset(Offset = "0x48")]
	private UIManualMapDebrisController m_RightCtrl;

	[Token(Token = "0x400FFAE")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIManualMapDebrisController> m_DebrisCtrlList;

	[Token(Token = "0x400FFAF")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_LeftArrowTips;

	[Token(Token = "0x400FFB0")]
	[FieldOffset(Offset = "0x54")]
	private GameObject m_RightArrowTips;

	[Token(Token = "0x400FFB1")]
	[FieldOffset(Offset = "0x58")]
	private List<int> m_MapTypes;

	[Token(Token = "0x6010A84")]
	[Address(RVA = "0x2C2D748", Offset = "0x2C2D748", VA = "0x2C2D748")]
	public UIManualMapController()
	{
	}

	[Token(Token = "0x6010A85")]
	[Address(RVA = "0x2C2D8A0", Offset = "0x2C2D8A0", VA = "0x2C2D8A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010A86")]
	[Address(RVA = "0x2C2D944", Offset = "0x2C2D944", VA = "0x2C2D944", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010A87")]
	[Address(RVA = "0x2C2DC24", Offset = "0x2C2DC24", VA = "0x2C2DC24", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010A88")]
	[Address(RVA = "0x2C2DC88", Offset = "0x2C2DC88", VA = "0x2C2DC88", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010A89")]
	[Address(RVA = "0x2C2DCEC", Offset = "0x2C2DCEC", VA = "0x2C2DCEC", Slot = "34")]
	protected override int GetMaxPage()
	{
		return default(int);
	}

	[Token(Token = "0x6010A8A")]
	[Address(RVA = "0x2C2DDB8", Offset = "0x2C2DDB8", VA = "0x2C2DDB8", Slot = "31")]
	public override void SetData(UIManualDataBase data)
	{
	}

	[Token(Token = "0x6010A8B")]
	[Address(RVA = "0x2C2DEB0", Offset = "0x2C2DEB0", VA = "0x2C2DEB0", Slot = "33")]
	public override void RefreshView()
	{
	}

	[Token(Token = "0x6010A8C")]
	[Address(RVA = "0x2C2E464", Offset = "0x2C2E464", VA = "0x2C2E464")]
	private void CreateDebris(UIManualMapDebrisData data)
	{
	}

	[Token(Token = "0x6010A8D")]
	[Address(RVA = "0x2C2EB20", Offset = "0x2C2EB20", VA = "0x2C2EB20")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010A8E")]
	[Address(RVA = "0x2C2EB28", Offset = "0x2C2EB28", VA = "0x2C2EB28")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010A8F")]
	[Address(RVA = "0x2C2EB30", Offset = "0x2C2EB30", VA = "0x2C2EB30")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6010A90")]
	[Address(RVA = "0x2C2EB38", Offset = "0x2C2EB38", VA = "0x2C2EB38")]
	public int _003C_003EiFixBaseProxy_GetMaxPage()
	{
		return default(int);
	}

	[Token(Token = "0x6010A91")]
	[Address(RVA = "0x2C2EB40", Offset = "0x2C2EB40", VA = "0x2C2EB40")]
	public void _003C_003EiFixBaseProxy_SetData(UIManualDataBase P0)
	{
	}

	[Token(Token = "0x6010A92")]
	[Address(RVA = "0x2C2EB48", Offset = "0x2C2EB48", VA = "0x2C2EB48")]
	public void _003C_003EiFixBaseProxy_RefreshView()
	{
	}
}
