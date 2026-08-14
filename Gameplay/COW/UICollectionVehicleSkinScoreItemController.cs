using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002576")]
internal class UICollectionVehicleSkinScoreItemController : UIBaseController
{
	[Token(Token = "0x400E7CF")]
	[FieldOffset(Offset = "0x28")]
	private UICollectionVehicleSkinScoreItemView m_View;

	[Token(Token = "0x400E7D0")]
	[FieldOffset(Offset = "0x2C")]
	private List<GameObject> m_UpIconList;

	[Token(Token = "0x400E7D1")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_DownIconList;

	[Token(Token = "0x400E7D2")]
	[FieldOffset(Offset = "0x34")]
	private Color COLOR_SCORE_RED;

	[Token(Token = "0x400E7D3")]
	[FieldOffset(Offset = "0x44")]
	private Color COLOR_SCORE_GREEN;

	[Token(Token = "0x600DB00")]
	[Address(RVA = "0x2CD8B34", Offset = "0x2CD8B34", VA = "0x2CD8B34")]
	public UICollectionVehicleSkinScoreItemController()
	{
	}

	[Token(Token = "0x600DB01")]
	[Address(RVA = "0x2CD9844", Offset = "0x2CD9844", VA = "0x2CD9844")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DB02")]
	[Address(RVA = "0x2CD8D14", Offset = "0x2CD8D14", VA = "0x2CD8D14", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DB03")]
	[Address(RVA = "0x2CD98E8", Offset = "0x2CD98E8", VA = "0x2CD98E8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DB04")]
	[Address(RVA = "0x2CD994C", Offset = "0x2CD994C", VA = "0x2CD994C")]
	public void SetUIData(string name, int scoreVal)
	{
	}

	[Token(Token = "0x600DB05")]
	[Address(RVA = "0x2CD9D48", Offset = "0x2CD9D48", VA = "0x2CD9D48")]
	public void SetArrowOffSet(int x)
	{
	}

	[Token(Token = "0x600DB06")]
	[Address(RVA = "0x2CDA100", Offset = "0x2CDA100", VA = "0x2CDA100")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DB07")]
	[Address(RVA = "0x2CDA108", Offset = "0x2CDA108", VA = "0x2CDA108")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
